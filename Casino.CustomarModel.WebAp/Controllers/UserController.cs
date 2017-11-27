using Casino.CustomarModel.WebAp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Casino.CustomarModel.Shared;
using Casino.CustomarModel.Web.Shared;
namespace Casino.CustomarModel.WebAp.Controllers
{
    public class UserController : ApiController
    {
        //[HttpGet]
        //public IList<UserModel> GetAllUsers()
        //{
        //    IUserFacade usersFacade = (IUserFacade)FacadeFactory.Instance.Create(FacadeType.UserFacade);
        //    OperationResult<IList<IUserDTO>> result = usersFacade.GetAllUser();
        //    List<UserModel> list = new List<UserModel>();
            
        //    if(result.IsValid())
        //    {
                
        //        foreach (var item in result.Data)
        //        {
        //            UserModel list1 = new UserModel();
        //            list1.Balance=item.Balance;
        //            list1.Blocked = item.Blocked;
        //            list1.Emailid = item.Emailid;
        //            list1.Name = item.Name;
        //            list.Add(list1);
        //        }
        //    }
        //    return list;
        //}

        [HttpGet]
        public UserModel GetUserById(string id)
        {
            IUserFacade usersFacade = (IUserFacade)FacadeFactory.Instance.Create(FacadeType.UserFacade);
            OperationResult<IUserDTO> result = usersFacade.GetUserById(id);
            //List<UserModel> list = new List<UserModel>();
            UserModel list1 = new UserModel();

            if (result.IsValid())
            {

                //foreach (var item in result.Data)
                //{
                list1.Balance = result.Data.Balance;
                list1.Blocked = result.Data.Blocked;
                list1.Emailid = result.Data.Emailid;
                list1.Name = result.Data.Name;
                //list.Add(list1);

            }
            return list1;
        }
        [HttpPut]
        public UserModel UpdateBlockedAmount(string emailid, int amt)
        {
            IUserFacade usersFacade = (IUserFacade)FacadeFactory.Instance.Create(FacadeType.UserFacade);
            OperationResult<IUserDTO> result = usersFacade.UpdateBlockedAmount(emailid,amt);
            //List<UserModel> list = new List<UserModel>();
            UserModel list1 = new UserModel();

            if (result.IsValid())
            {

                //foreach (var item in result.Data)
                //{
                list1.Balance = result.Data.Balance;
                list1.Blocked = result.Data.Blocked;
                list1.Emailid = result.Data.Emailid;
                list1.Name = result.Data.Name;
                //list.Add(list1);

            }
            return list1;
        }

        [HttpPut]
        public UserModel UpdateBalanceAmount(string emailid, int fact)
        {
            IUserFacade usersFacade = (IUserFacade)FacadeFactory.Instance.Create(FacadeType.UserFacade);
            OperationResult<IUserDTO> result = usersFacade.UpdateBalanceAmount(emailid, fact);
            //List<UserModel> list = new List<UserModel>();
            UserModel list1 = new UserModel();

            if (result.IsValid())
            {

                //foreach (var item in result.Data)
                //{
                list1.Balance = result.Data.Balance;
                list1.Blocked = result.Data.Blocked;
                list1.Emailid = result.Data.Emailid;
                list1.Name = result.Data.Name;
                //list.Add(list1);

            }
            return list1;
        }
    }
}
