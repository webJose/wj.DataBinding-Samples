using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wj.DataBinding;

namespace SampleRepository.Domain
{
    public class Entity : NotifyPropertyChanged
    {
        #region Properties
        private long m_id;
        public long Id
        {
            get { return m_id; }
            set { SaveAndNotify(ref m_id, value); }
        }
        #endregion
    }
}
