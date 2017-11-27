using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.CustomarModel.Shared
{
    public interface IUserBDC : IBusinessDomainComponent
    {
        OperationResult<IList<IUserDTO>> GetAllUser();
        OperationResult<IUserDTO> GetUserById(string id);

        OperationResult<IUserDTO> UpdateBalanceAmount(string emailid, int amt);
        OperationResult<IUserDTO> UpdateBlockedAmount(string emailid, int amt);
        OperationResult<IUserDTO> UpdateUser(int persondid, int amt);
        OperationResult<IUserDTO> CreateUser(IUserDTO usersDTO);
        OperationResult<IList<IUserDTO>> SearchCustomer(string name, string email, string contact);
    }
}
