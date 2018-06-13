using System;
using wj.DataBinding;

namespace Shared.Selectables
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
