using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.CustomarModel.Shared
{
    /// <summary>
    /// The Facade Types
    /// </summary>
    public enum FacadeType
    {
       
        /// <summary>
        /// Notice Facade
        /// </summary>
        [QualifiedTypeName("Casino.CustomarModel.BusinessFacades.dll", "Casino.CustomarModel.BusinessFacades.UserFacade")]
        UserFacade = 0

      
    }
}
