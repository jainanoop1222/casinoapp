using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.CustomarModel.Shared
{ 
    public interface IUserDTO : IDTO
    {
         int PersonID { get; set; }
         string Name { get; set; }
         System.DateTime DateOfBirth { get; set; }
         string Contact { get; set; }
         string Emailid { get; set; }
         int Balance { get; set; }
         int Blocked { get; set; }
         string UniqueID { get; set; }
         byte[] Image { get; set; }
    }
}
