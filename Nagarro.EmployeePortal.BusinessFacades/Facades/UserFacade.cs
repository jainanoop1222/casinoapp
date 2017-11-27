using Casino.CustomarModel.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.CustomarModel.BusinessFacades
{

    public class UserFacade : FacadeBase, IUserFacade
    {
        public UserFacade()
            : base(FacadeType.UserFacade)
        {

        }
        public OperationResult<IList<IUserDTO>> SearchCustomer(string name, string email, string contact)
        {
            IUserBDC UserBDC = (IUserBDC)BDCFactory.Instance.Create(BDCType.UserBDC);
            return UserBDC.SearchCustomer( name,  email,  contact);
        }
        public OperationResult<IUserDTO> GetUserById(string id)
        {
            IUserBDC UserBDC = (IUserBDC)BDCFactory.Instance.Create(BDCType.UserBDC);
            return UserBDC.GetUserById(id);
        }
        public OperationResult<IUserDTO> CreateUser(IUserDTO UserDTO)
        {
            IUserBDC UserBDC = (IUserBDC)BDCFactory.Instance.Create(BDCType.UserBDC);
            return UserBDC.CreateUser(UserDTO);
        }
        //public OperationResult<IList<IUserDTO>> SearchCustomer(string nameSearch, string emailSearch, string contactSearch)
        //{
        //    IUserBDC UserBDC = (IUserBDC)BDCFactory.Instance.Create(BDCType.UserBDC);
        //    return UserBDC.SearchCustomer(nameSearch, emailSearch, contactSearch);
        //}
        public OperationResult<IList<IUserDTO>> GetAllUser()
        {
            IUserBDC UserBDC = (IUserBDC)BDCFactory.Instance.Create(BDCType.UserBDC);
            return UserBDC.GetAllUser();

        }
        public OperationResult<IUserDTO> UpdateUser(int persondid, int amt)
        {
            IUserBDC UserBDC = (IUserBDC)BDCFactory.Instance.Create(BDCType.UserBDC);
            return UserBDC.UpdateUser(persondid,amt);
        }
        public OperationResult<IUserDTO> UpdateBalanceAmount(string emailid, int amt)
        {
            IUserBDC UserBDC = (IUserBDC)BDCFactory.Instance.Create(BDCType.UserBDC);
            return UserBDC.UpdateBalanceAmount(emailid, amt);
        }
        public OperationResult<IUserDTO> UpdateBlockedAmount(string emailid, int amt)
        {
            IUserBDC UserBDC = (IUserBDC)BDCFactory.Instance.Create(BDCType.UserBDC);
            return UserBDC.UpdateBlockedAmount(emailid, amt);
        }
    }
}
