using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleRepository.Domain
{
    public class Person : Entity
    {
        #region Properties
        private string m_firstName;
        public string FirstName
        {
            get { return m_firstName; }
            set { SaveAndNotify(ref m_firstName, value); }
        }

        private string m_lastName;
        public string LastName
        {
            get { return m_lastName; }
            set { SaveAndNotify(ref m_lastName, value); }
        }
        #endregion
    }
}
