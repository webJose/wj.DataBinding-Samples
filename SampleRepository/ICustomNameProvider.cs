using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleRepository
{
    public interface ICustomNameProvider
    {
        /// <summary>
        /// Gets the custom name meant to replace the provided name.
        /// </summary>
        /// <param name="name">Name to replace or transform.</param>
        /// <returns>The custom name that corresponds to the provided name.</returns>
        string GetCustomName(string name);
    }
}
