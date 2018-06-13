using SampleRepository.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wj.DataBinding;

namespace DataBindingSampleWPF.ViewModels
{
    public class MainViewModel : NotifyPropertyChanged
    {
        #region Properties

        public ObservableCollectionEx<Person> AllPersons { get; private set; }

        public ObservableCollectionEx<Shared.Selectables.Person> SelectablePersons { get; private set; }

        public ObservableCollectionEx<Person> SelectedPersons { get; private set; }

        private TimeSpan? m_frozenOperationTime;
        public TimeSpan? FrozenOperationTime
        {
            get { return m_frozenOperationTime; }
            set
            {
                bool changed = SaveAndNotify(ref m_frozenOperationTime, value);
                if (changed)
                {
                    RaisePropertyChanged(nameof(PerformanceGain));
                }
            }
        }

        private TimeSpan? m_unfrozenOperationTime;
        public TimeSpan? UnfrozenOperationTime
        {
            get { return m_unfrozenOperationTime; }
            set
            {
                bool changed = SaveAndNotify(ref m_unfrozenOperationTime, value);
                if (changed)
                {
                    RaisePropertyChanged(nameof(PerformanceGain));
                }
            }
        }

        public double? PerformanceGain
        {
            get
            {
                if (!FrozenOperationTime.HasValue || !UnfrozenOperationTime.HasValue)
                {
                    return null;
                }
                return (UnfrozenOperationTime.Value - FrozenOperationTime.Value).TotalMilliseconds / FrozenOperationTime.Value.TotalMilliseconds; }
        }

        private bool m_busyWork;
        public bool BusyWork
        {
            get { return m_busyWork; }
            set
            {
                SaveAndNotify(ref m_busyWork, value);
                WindowCursor = BusyWork ? Cursors.Wait : null;
            }
        }
        private Cursor m_windowCursor;
        public Cursor WindowCursor
        {
            get { return m_windowCursor; }
            set { SaveAndNotify(ref m_windowCursor, value); }
        }
        #endregion

        #region CanExecute Properties

        private bool m_canExecuteTestStep;
        public bool CanExecuteTestStep
        {
            get { return m_canExecuteTestStep; }
            private set { SaveAndNotify(ref m_canExecuteTestStep, value); }
        }
        #endregion

        #region Command Properties
        public RelayCommand SelectAllPersonsCmd
        {
            get { return new RelayCommand(o => true, o => SelectAllPersons()); }
        }

        public RelayCommand RunUnfrozenOperationCmd
        {
            get
            {
                return new RelayCommand(o => CanExecuteTestStep, o => UnfrozenOperationTime = TimeOperation(SelectAllAndMoveUnfrozen));
            }
        }

        public RelayCommand RunFrozenOperationCmd
        {
            get
            {
                return new RelayCommand(o => CanExecuteTestStep, o => FrozenOperationTime = TimeOperation(SelectAllAndMoveFrozen));
            }
        }

        public RelayCommand ResetGridsCmd
        {
            get
            {
                return new RelayCommand(o => true, o => ResetGrids());
            }
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            bool designMode = DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject());
            AllPersons = new ObservableCollectionEx<Person>
            (
                SampleRepository.Repositories.PersonRepository.GetAll(designMode ? (int?)20 : null)
            );
            SelectablePersons = new ObservableCollectionEx<Shared.Selectables.Person>();
            SelectablePersons.CollectionChanged += (s, o) => CanExecuteTestStep = SelectablePersons.Count > 0;
            ResetSelectablePersonsCollection();
            SelectedPersons = new ObservableCollectionEx<Person>();
        }
        #endregion

        #region Methods

        private void ResetSelectablePersonsCollection()
        {
            SelectablePersons.FreezeCollectionNotifications();
            SelectablePersons.Clear();
            foreach (Person p in AllPersons)
            {
                SelectablePersons.Add(new Shared.Selectables.Person(p));
            }
            SelectablePersons.UnfreezeCollectionNotifications();
        }

        private void ResetGrids()
        {
            BusyWork = true;
            ResetSelectablePersonsCollection();
            SelectedPersons.FreezeCollectionNotifications();
            SelectedPersons.Clear();
            SelectedPersons.UnfreezeCollectionNotifications();
            BusyWork = false;
        }

        private void SelectAllPersons()
        {
            foreach (Shared.Selectables.Person p in SelectablePersons)
            {
                p.Selected = true;
            }
        }

        private List<Shared.Selectables.Person> CopySelectedToSecondGrid()
        {
            List<Shared.Selectables.Person> selections = new List<Shared.Selectables.Person>();
            foreach (Shared.Selectables.Person p in SelectablePersons)
            {
                if (p.Selected)
                {
                    selections.Add(p);
                    SelectedPersons.Add(p);
                }
            }
            return selections;
        }

        private void RemoveFromFirstGrid(List<Shared.Selectables.Person> persons)
        {
            foreach(Shared.Selectables.Person p in persons)
            {
                SelectablePersons.Remove(p);
            }
        }

        private TimeSpan TimeOperation(Action operation)
        {
            BusyWork = true;
            DateTime start = DateTime.Now;
            operation();
            DateTime end = DateTime.Now;
            BusyWork = false;
            return end - start;
        }
        private void SelectAllAndMoveUnfrozen()
        {
            SelectAllPersons();
            RemoveFromFirstGrid(CopySelectedToSecondGrid());
        }

        private void SelectAllAndMoveFrozen()
        {
            SelectablePersons.FreezeCollectionNotifications();
            SelectedPersons.FreezeCollectionNotifications();
            SelectAllPersons();
            RemoveFromFirstGrid(CopySelectedToSecondGrid());
            SelectedPersons.UnfreezeCollectionNotifications();
            SelectablePersons.UnfreezeCollectionNotifications();
        }
        #endregion
    }
}
