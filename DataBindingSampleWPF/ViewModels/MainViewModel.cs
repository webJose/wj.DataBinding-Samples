using SampleRepository.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wj.DataBinding;

namespace DataBindingSampleWPF.ViewModels
{
    public class MainViewModel : NotifyPropertyChanged
    {
        #region Properties
        public ObservableCollection<Selectables.Person> SelectablePersons { get; set; }
        public ObservableCollection<Person> SelectedPersons { get; set; }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            SelectablePersons = new ObservableCollection<Selectables.Person>
            (
                SampleRepository.Repositories.PersonRepository.GetAll().Select(p => new Selectables.Person(p))
            );
            SelectedPersons = new ObservableCollection<Person>();
        }
        #endregion
    }
}
