using Casino.CustomarModel.Shared;
using Casino.CustomarModel.Web.Shared;
using CasinoCustomar.Models;
//using Nagarro.CasinoApplication.Web.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;


namespace CasinoCustomar.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public byte[] convertToBytes(HttpPostedFileBase ImageData)
        {
            byte[] imageBytes = null;
            BinaryReader reader = new BinaryReader(ImageData.InputStream);
            imageBytes = reader.ReadBytes((int)ImageData.ContentLength);
            return imageBytes;
        }
        public ViewResult GetAllUser()//int? page
        {
            IUserFacade usersFacade = (IUserFacade)FacadeFactory.Instance.Create(FacadeType.UserFacade);
            OperationResult<IList<IUserDTO>> result = usersFacade.GetAllUser();
            List<UserModel> list = new List<UserModel>();
            //List<UserModel> list1 = new List<UserModel>();
            if (result.IsValid())
            {
                foreach (var item in result.Data)
                {
                    UserModel user = new UserModel();
                    DTOConverter.FillViewModelFromDTO(user, item);
                    list.Add(user);
                }
                
            }
            else
            {                
            }
            //int pagesize = 3;
            //int pagenumber = (page ?? 1);
            //return View(list.topagedlist(pagenumber, pagesize));
            return View(list);   
        }
        [HttpGet]
        public ViewResult CreateUsers()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateUsers(UserModel user)
        {
            IUserFacade usersFacade = (IUserFacade)FacadeFactory.Instance.Create(FacadeType.UserFacade);
            IUserDTO usersDTO = (IUserDTO)DTOFactory.Instance.Create(DTOType.UserDTO);
            HttpPostedFileBase file = Request.Files["ImageData"];
            user.Image = convertToBytes(file);
            if (ModelState.IsValid) { 
            DTOConverter.FillDTOFromViewModel(usersDTO, user);

            OperationResult<IUserDTO> result = usersFacade.CreateUser(usersDTO);
            //List<UsersModel> list = new List<UsersModel>();
            if (result.IsValid())
            {
                //foreach (var item in result.Data)
                //{
                //UsersModel user1 = new UsersModel();
                //DTOConverter.FillViewModelFromDTO(user, result);
                //list.Add(user);
                //Console.WriteLine(item.Balance);
                //Console.WriteLine(item.Contact);
                //}
                Console.WriteLine("Completed");
            }
            }
            if (ModelState.IsValid)
            {
                DTOConverter.FillDTOFromViewModel(usersDTO, user);
                OperationResult<IUserDTO> result = usersFacade.CreateUser(usersDTO);
                if (result.ValidationResult != null && result.ValidationResult.Errors != null)
                {
                    IList<EmployeePortalValidationFailure> resultFail = result.ValidationResult.Errors;
                    foreach (var item in resultFail)
                    {
                        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    }
                    return View();
                }
            } 
            //else
            //{
            //    IList<EmployeePortalValidationFailure> resultFail = result.ValidationResult.Errors;
            //    foreach (var item in resultFail)
            //    {

            //    }
            //}
           return RedirectToAction("GetAllUser","User");
        }
        public ActionResult Imag()
        {
            return View();
        }
        public ActionResult Recharge(int CustomerId, int RechargeAmount)
        {
            IUserFacade userFacade = (IUserFacade)FacadeFactory.Instance.Create(FacadeType.UserFacade);
            OperationResult<IUserDTO> result = userFacade.UpdateUser(CustomerId, RechargeAmount);
            if (result.IsValid())
            {

            }
            return RedirectToAction("GetAllUser", "User");
        }
       
        public ViewResult SearchUser(string nameSearch, string contactSearch, string emailSearch)
        {
            if (nameSearch.Length == 0 && contactSearch.Length == 0 && emailSearch.Length == 0)
            {
                //return PartialView("GetAllUser");
                return this.GetAllUser();

            }
            else
            {
                if (nameSearch.Length == 0)
                {
                    nameSearch = null;
                }

                if (contactSearch.Length == 0)
                {
                    contactSearch = null;
                }

                if (emailSearch.Length == 0)
                {
                    emailSearch = null;
                }

                IUserFacade userFacade = (IUserFacade)FacadeFactory.Instance.Create(FacadeType.UserFacade);
                OperationResult<IList<IUserDTO>> resultAllCustomers = userFacade.SearchCustomer(nameSearch, emailSearch, contactSearch);
                List<UserModel> result = new List<UserModel>();
                if (resultAllCustomers.IsValid())
                {
                    foreach (var item in resultAllCustomers.Data)
                    {
                        UserModel userData = new UserModel();
                        DTOConverter.FillViewModelFromDTO(userData, item);
                        result.Add(userData);
                    }
                }
                else
                {
                    IList<EmployeePortalValidationFailure> resultFail = resultAllCustomers.ValidationResult.Errors;
                    foreach (var item in resultFail)
                    {

                    }
                }
                return View("GetAllUser", result);
            }

        }

    }
}