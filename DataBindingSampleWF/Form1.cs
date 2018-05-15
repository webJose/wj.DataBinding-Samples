using SampleRepository.Domain;
using SampleRepository.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingSampleWF
{
    public partial class Form1 : Form
    {
        #region Properties
        private BindingList<Selectables.Person> SelectablePersons { get; set; }
        private BindingList<Person> SelectedPersons { get; set; }
        #endregion

        #region Constructors
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private BindingList<Selectables.Person> BuildPersonBindingList(IList<Person> persons)
        {
            return new BindingList<Selectables.Person>(persons.Select(p => new Selectables.Person(p)).ToList());
        }
        #endregion

        #region Event Handlers
        private void Form1_Load(object sender, EventArgs e)
        {
            SelectablePersons = BuildPersonBindingList(PersonRepository.GetAll());
            dgv1.AutoGenerateColumns = false;
            dgv1.DataSource = SelectablePersons;
            SelectedPersons = new BindingList<Person>();
            dgv2.DataSource = SelectedPersons;
        }

        private void btnMoveToOtherDGV_Click(object sender, EventArgs e)
        {
            List<Selectables.Person> selectedPersons = new List<Selectables.Person>();
            foreach(Selectables.Person p in SelectablePersons)
            {
                if (p.Selected)
                {
                    selectedPersons.Add(p);
                    //Implicit cast operator in play here.
                    SelectedPersons.Add(p);
                }
            }

            foreach(Selectables.Person p in selectedPersons)
            {
                SelectablePersons.Remove(p);
            }
        }
        #endregion
    }
}
