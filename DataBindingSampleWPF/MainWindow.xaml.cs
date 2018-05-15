using DataBindingSampleWPF.ViewModels;
using SampleRepository.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBindingSampleWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Properties
        public MainViewModel Model { get; set; }
        #endregion

        #region Constructors
        public MainWindow()
        {
            Model = new MainViewModel();
            InitializeComponent();
            DataContext = Model;
        }
        #endregion

        #region Event Handlers
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Selectables.Person> selectedPersons = new List<Selectables.Person>();
            foreach(Selectables.Person p in Model.SelectablePersons)
            {
                if (p.Selected)
                {
                    selectedPersons.Add(p);
                    //Implicit cast operator in play here.
                    Model.SelectedPersons.Add(p);
                }
            }
            foreach(Selectables.Person p in selectedPersons)
            {
                Model.SelectablePersons.Remove(p);
            }
        }
        #endregion
    }
}
