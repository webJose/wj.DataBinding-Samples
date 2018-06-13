using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleRepository
{
    public class CustomPropertyNamingStrategy : NamingStrategy
    {
        #region Properties

        /// <summary>
        /// Gets or sets the name provider object.
        /// </summary>
        protected ICustomNameProvider NameProvider { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a new instance of this class using the specified name provider.
        /// </summary>
        /// <param name="nameProvider">The name provider object to use to resolve property 
        /// names.</param>
        public CustomPropertyNamingStrategy(ICustomNameProvider nameProvider)
        {
            NameProvider = nameProvider;
        }
        #endregion

        #region Methods
        protected override string ResolvePropertyName(string name)
        {
            return NameProvider.GetCustomName(name);
        }
        #endregion
    }
}
