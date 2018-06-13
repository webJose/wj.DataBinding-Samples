using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleRepository
{
    public class LowerCaseNameProvider : ICustomNameProvider
    {
        #region ICustomNameProvider
        public string GetCustomName(string name)
        {
            StringBuilder sb = new StringBuilder(name.Length + 1);
            for (int i = 0; i < name.Length; ++i)
            {
                char c = name[i];
                if (Char.IsUpper(c))
                {
                    c = Char.ToLower(c);
                    if (i > 0)
                    {
                        sb.Append('_');
                    }
                }
                sb.Append(c);
            }
            return sb.ToString();
        }
        #endregion
    }
}
