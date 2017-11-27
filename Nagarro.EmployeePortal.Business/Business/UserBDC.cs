using Casino.CustomarModel.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.CustomarModel.Business
{
    public class UserBDC : BDCBase, IUserBDC
    {
        public UserBDC()
            : base(BDCType.UserBDC)
        {

        }
        //public OperationResult<IUserDTO> 
        //{
        //    IUserBDC usersBDC = (IUserBDC)BDCFactory.Instance.Create(BDCType.UserBDC);
        //    return usersBDC.CreateUser(usersDTO);
        //}
        public OperationResult<IUserDTO> CreateUser(IUserDTO usersDTO)
        {

            OperationResult<IUserDTO> retVal = null;

            try
            {
                IUserDAC usersDAC = (IUserDAC)DACFactory.Instance.Create(DACType.UserDAC);
                IUserDTO list = usersDAC.CreateUser(usersDTO);
                retVal = OperationResult<IUserDTO>.CreateSuccessResult(list);
            }
            catch (DACException dacEx)
            {

                retVal = OperationResult<IUserDTO>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                retVal = OperationResult<IUserDTO>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return retVal;

        }

        public OperationResult<IUserDTO> GetUserById(string id)
        {

            OperationResult<IUserDTO> retVal = null;

            try
            {
                IUserDAC usersDAC = (IUserDAC)DACFactory.Instance.Create(DACType.UserDAC);
                IUserDTO list = usersDAC.GetUserById(id);
                retVal = OperationResult<IUserDTO>.CreateSuccessResult(list);
            }
            catch (DACException dacEx)
            {

                retVal = OperationResult<IUserDTO>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                retVal = OperationResult<IUserDTO>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return retVal;

        }
        //public OperationResult<IList<IUserDTO>> SearchCustomer(string nameSearch, string emailSearch, string contactSearch)
        //{
        //    IUserBDC usersBDC = (IUserBDC)BDCFactory.Instance.Create(BDCType.UserBDC);
        //    return usersBDC.SearchCustomer(nameSearch, emailSearch, contactSearch);
        //}
        //public OperationResult<IList<IUserDTO>> GetAllUser()
        //{
        //    IUserDAC usersDAC = (IUserDAC)DACFactory.Instance.Create(DACType.UserDAC);
        //    return usersDAC.GetAllUser();

        //}
        public OperationResult<IList<IUserDTO>> GetAllUser()
        {

            OperationResult<IList<IUserDTO>> retVal = null;

            try
            {
                IUserDAC usersDAC = (IUserDAC)DACFactory.Instance.Create(DACType.UserDAC);
                IList<IUserDTO> list = usersDAC.GetAllUser();
                retVal = OperationResult<IList<IUserDTO>>.CreateSuccessResult(list);
            }
            catch (DACException dacEx)
            {

                retVal = OperationResult<IList<IUserDTO>>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                retVal = OperationResult<IList<IUserDTO>>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return retVal;

        }
        public OperationResult<IList<IUserDTO>> SearchCustomer(string name, string email, string contact)
        {
            OperationResult<IList<IUserDTO>> retVal = null;

            try
            {
                IUserDAC usersDAC = (IUserDAC)DACFactory.Instance.Create(DACType.UserDAC);
                IList<IUserDTO> list = usersDAC.SearchCustomer( name,  email,  contact);
                retVal = OperationResult<IList<IUserDTO>>.CreateSuccessResult(list);
            }
            catch (DACException dacEx)
            {

                retVal = OperationResult<IList<IUserDTO>>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                retVal = OperationResult<IList<IUserDTO>>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return retVal;
        }
            
            public OperationResult<IUserDTO> UpdateUser(int persondid, int amt)
              {

            OperationResult<IUserDTO> retVal = null;

            try
            {
                IUserDAC usersDAC = (IUserDAC)DACFactory.Instance.Create(DACType.UserDAC);
                IUserDTO list = usersDAC.UpdateUser(persondid, amt);
                retVal = OperationResult<IUserDTO>.CreateSuccessResult(list);
            }
            catch (DACException dacEx)
            {

                retVal = OperationResult<IUserDTO>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                retVal = OperationResult<IUserDTO>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return retVal;

        }

            public OperationResult<IUserDTO> UpdateBalanceAmount(string emailid, int amt)
            {

                OperationResult<IUserDTO> retVal = null;

                try
                {
                    IUserDAC usersDAC = (IUserDAC)DACFactory.Instance.Create(DACType.UserDAC);
                    IUserDTO list = usersDAC.UpdateBalanceAmount(emailid, amt);
                    retVal = OperationResult<IUserDTO>.CreateSuccessResult(list);
                }
                catch (DACException dacEx)
                {

                    retVal = OperationResult<IUserDTO>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
                }
                catch (Exception ex)
                {
                    ExceptionManager.HandleException(ex);
                    retVal = OperationResult<IUserDTO>.CreateErrorResult(ex.Message, ex.StackTrace);
                }
                return retVal;

            }

            public OperationResult<IUserDTO> UpdateBlockedAmount(string emailid, int amt)
            {

                OperationResult<IUserDTO> retVal = null;

                try
                {
                    IUserDAC usersDAC = (IUserDAC)DACFactory.Instance.Create(DACType.UserDAC);
                    IUserDTO list = usersDAC.UpdateBlockedAmount(emailid, amt);
                    retVal = OperationResult<IUserDTO>.CreateSuccessResult(list);
                }
                catch (DACException dacEx)
                {

                    retVal = OperationResult<IUserDTO>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
                }
                catch (Exception ex)
                {
                    ExceptionManager.HandleException(ex);
                    retVal = OperationResult<IUserDTO>.CreateErrorResult(ex.Message, ex.StackTrace);
                }
                return retVal;

            }
        //public OperationResult<IUserDTO> UpdateUser(IUserDTO usersDTO)
        //{
        //    IUserBDC usersBDC = (IUserBDC)BDCFactory.Instance.Create(BDCType.UserBDC);
        //    return usersBDC.UpdateUser(usersDTO);
        //}

        //public OperationResult<IUsersDTO> UsersMethod(IUsersDTO usersDTO)
        //{
        //    OperationResult<IUsersDTO> retVal = null;

        //    try
        //    {
        //        IUsersDAC usersDAC = (IUsersDAC)DACFactory.Instance.Create(DACType.UsersDAC);
        //        usersDTO = usersDAC.UsersMethod(usersDTO);
        //        retVal = OperationResult<IUsersDTO>.CreateSuccessResult(usersDTO);
        //    }
        //    catch (DACException dacEx)
        //    {
        //        retVal = OperationResult<IUsersDTO>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
        //    }
        //    catch (Exception ex)
        //    {
        //        ExceptionManager.HandleException(ex);
        //        retVal = OperationResult<IUsersDTO>.CreateErrorResult(ex.Message, ex.StackTrace);
        //    }
        //    return retVal;
        //}
    }
}
