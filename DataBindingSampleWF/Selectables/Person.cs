using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wj.DataBinding;

namespace DataBindingSampleWF.Selectables
{
    public class Person : Container<SampleRepository.Domain.Person>
    {
        #region Properties
        private bool m_selected;
        public bool Selected
        {
            get { return m_selected; }
            set { SaveAndNotify(ref m_selected, value); }
        }
        #endregion

        #region Constructors
        public Person(SampleRepository.Domain.Person person)
            : base(person)
        { }
        #endregion
    }
}
