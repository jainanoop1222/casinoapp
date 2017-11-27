using Casino.CustomarModel.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.CustomarModel.DTOModel
{
    [EntityMapping("Casino.CustomarModel.EntityDataModel.EntityModel.User", MappingType.TotalExplicit)]
    [ViewModelMapping("CasinoCustomar.Models.UserModel", MappingType.TotalExplicit)] 

    public class UserDTO : DTOBase, IUserDTO
    {
        public UserDTO()
            : base(DTOType.UserDTO)
        {

        }
        [ViewModelPropertyMapping(MappingDirectionType.Both, "PersonID")]
        [EntityPropertyMapping(MappingDirectionType.Both, "PersonID")]
        public int PersonID { get; set; }
        [ViewModelPropertyMapping(MappingDirectionType.Both, "Name")]
        [EntityPropertyMapping(MappingDirectionType.Both, "Name")]
        public string Name { get; set; }
        [ViewModelPropertyMapping(MappingDirectionType.Both, "DateOfBirth")]
        [EntityPropertyMapping(MappingDirectionType.Both, "DateOfBirth")]
        public System.DateTime DateOfBirth { get; set; }
        [ViewModelPropertyMapping(MappingDirectionType.Both, "Contact")]
        [EntityPropertyMapping(MappingDirectionType.Both, "Contact")]
        public string Contact { get; set; }
        [ViewModelPropertyMapping(MappingDirectionType.Both, "Emailid")]
        [EntityPropertyMapping(MappingDirectionType.Both, "Emailid")]
        public string Emailid { get; set; }
        [ViewModelPropertyMapping(MappingDirectionType.Both, "Balance")]
        [EntityPropertyMapping(MappingDirectionType.Both, "Balance")]
        public int Balance { get; set; }
        [ViewModelPropertyMapping(MappingDirectionType.Both, "Blocked")]
        [EntityPropertyMapping(MappingDirectionType.Both, "Blocked")]
        public int Blocked { get; set; }
        [ViewModelPropertyMapping(MappingDirectionType.Both, "UniqueID")]
        [EntityPropertyMapping(MappingDirectionType.Both, "UniqueID")]
        public string UniqueID { get; set; }
        [ViewModelPropertyMapping(MappingDirectionType.Both, "Image")]
        [EntityPropertyMapping(MappingDirectionType.Both, "Image")]
        public byte[] Image { get; set; }
    }
         
}
