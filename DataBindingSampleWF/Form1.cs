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
        private BindingList<Shared.Selectables.Person> SelectablePersons { get; set; }
        private BindingList<Person> SelectedPersons { get; set; }
        #endregion

        #region Constructors
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private BindingList<Shared.Selectables.Person> BuildPersonBindingList(IList<Person> persons)
        {
            return new BindingList<Shared.Selectables.Person>(persons.Select(p => new Shared.Selectables.Person(p)).ToList());
        }
        #endregion

        #region Event Handlers
        private void Form1_Load(object sender, EventArgs e)
        {
            SelectablePersons = BuildPersonBindingList(PersonRepository.GetAll(20));
            dgv1.AutoGenerateColumns = false;
            dgv1.DataSource = SelectablePersons;
            SelectedPersons = new BindingList<Person>();
            dgv2.AutoGenerateColumns = false;
            dgv2.DataSource = SelectedPersons;
        }

        private void btnMoveToOtherDGV_Click(object sender, EventArgs e)
        {
            List<Shared.Selectables.Person> selectedPersons = new List<Shared.Selectables.Person>();
            foreach (Shared.Selectables.Person p in SelectablePersons)
            {
                if (p.Selected)
                {
                    selectedPersons.Add(p);
                    //Implicit cast operator in play here.
                    SelectedPersons.Add(p);
                }
            }
            foreach (Shared.Selectables.Person p in selectedPersons)
            {
                SelectablePersons.Remove(p);
            }
        }
        #endregion
    }
}
