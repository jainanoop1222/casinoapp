using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.CustomarModel.Shared
{
    public interface IUserDAC : IDataAccessComponent
    {
        IList<IUserDTO> GetAllUser();
        IUserDTO GetUserById(string id);
        IUserDTO UpdateBalanceAmount(string emailid, int amt);
        IUserDTO UpdateBlockedAmount(string emailid, int amt);
        IUserDTO UpdateUser(int persondid,int amt);
        IUserDTO CreateUser(IUserDTO usersDTO);
        IList<IUserDTO> SearchCustomer(string name, string email, string contact);
    }
}
