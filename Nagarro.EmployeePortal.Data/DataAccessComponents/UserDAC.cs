using Casino.CustomarModel.EntityDataModel;
using Casino.CustomarModel.EntityDataModel.EntityModel;
using Casino.CustomarModel.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.CustomarModel.Data
{

    public class UserDAC : DACBase, IUserDAC
    {
        public UserDAC()
            : base(DACType.UserDAC)
        {

        }
        public IList<IUserDTO> GetAllUser()
        {
            IList<IUserDTO> usersDTOList = new List<IUserDTO>();
            using (CasinoCustomerEntities context = new CasinoCustomerEntities())
            {
                var usersEntity = context.Users.ToList();
                foreach (var user in usersEntity)
                {
                    IUserDTO usersDTO = (IUserDTO)DTOFactory.Instance.Create(DTOType.UserDTO);
                    EntityConverter.FillDTOFromEntity(user, usersDTO);
                    usersDTOList.Add(usersDTO);
                }
                context.SaveChanges();
            }
            return usersDTOList;
        }


        public IUserDTO GetUserById(string id)
        {
            IUserDTO usersDTO = (IUserDTO)DTOFactory.Instance.Create(DTOType.UserDTO);
            using (CasinoCustomerEntities context = new CasinoCustomerEntities())
            {
                var usersEntity = context.Users.ToList();
                foreach (var user in usersEntity)
                {
                  if(user.Emailid==id)
                  {
                      //IUserDTO usersDTO = (IUserDTO)DTOFactory.Instance.Create(DTOType.UserDTO);
                      EntityConverter.FillDTOFromEntity(user, usersDTO);
                      
                  }
                    
                }
                context.SaveChanges();
            }
            return usersDTO;
        }


        public IUserDTO UpdateUser(int persondid, int amt)
        {
            IUserDTO usersDTO1 = null;
            User updateUser = new User();
            using (CasinoCustomerEntities context = new CasinoCustomerEntities())
            {
                User customer = context.Users.Where(item => item.PersonID == persondid).FirstOrDefault();
                if(customer!=null)
                {
                    customer.Balance += amt;
                }
                if(context.SaveChanges()>0)
                {
                    EntityConverter.FillDTOFromEntity(customer, usersDTO1);
                }
            }
            return usersDTO1;
        }
        public IUserDTO UpdateBlockedAmount(string emailid, int amt)
        {
            IUserDTO usersDTO1 = (IUserDTO)DTOFactory.Instance.Create(DTOType.UserDTO);
            User updateUser = new User();
            using (CasinoCustomerEntities context = new CasinoCustomerEntities())
            {
                User customer = context.Users.Where(item => item.Emailid == emailid).FirstOrDefault();
                if (customer != null)
                {
                    
                    customer.Balance -= amt;
                    customer.Blocked += amt;
                }
                if (context.SaveChanges() > 0)
                {
                    
                    EntityConverter.FillDTOFromEntity(customer, usersDTO1);
                }
            }
            return usersDTO1;
        }
        public IUserDTO UpdateBalanceAmount(string emailid, int amt)
        {
            IUserDTO usersDTO1 = (IUserDTO)DTOFactory.Instance.Create(DTOType.UserDTO);
            User updateUser = new User();
            using (CasinoCustomerEntities context = new CasinoCustomerEntities())
            {
                User customer = context.Users.Where(item => item.Emailid == emailid).FirstOrDefault();
                if (customer != null)
                {
                    customer.Balance += amt;
                    customer.Blocked = 0;
                }
                if (context.SaveChanges() > 0)
                {
                    EntityConverter.FillDTOFromEntity(customer, usersDTO1);
                }
            }
            return usersDTO1;
        }

        public IUserDTO CreateUser(IUserDTO usersDTO)
        {
            IUserDTO usersDTO1 = (IUserDTO)DTOFactory.Instance.Create(DTOType.UserDTO);
            using (CasinoCustomerEntities context = new CasinoCustomerEntities())
            {
                User user = new User();
                EntityConverter.FillEntityFromDTO(usersDTO, user);
                //user.IsActive = true;

                context.Users.Add(user);
                if (context.SaveChanges() > 0)
                {
                    EntityConverter.FillDTOFromEntity(user, usersDTO1);
                }
                //context.SaveChanges();

            }
            //            try
            //{
            //    using (CustomerPortalEntities context = new CustomerPortalEntities())
            //    {
            //        CustomerTable customer = new CustomerTable();
            //        custDTO.BlockBalance = 0;
            //        custDTO.AccountBalance = 500;
            //        EntityDataModel.EntityConverter.FillEntityFromDTO(custDTO, customer);
            //        context.CustomerTables.Add(customer);
            //        if (context.SaveChanges() > 0)
            //        {
            //            custDTO.CustomerId = customer.CustomerId;
            //            createCustomerRetval = custDTO;
            //        }
            //    }


            return usersDTO1;
        }
        public IList<IUserDTO> SearchCustomer(string name, string email, string contact)
        {
            IList<IUserDTO> returnedList = null;

            using (CasinoCustomerEntities context = new CasinoCustomerEntities())
            {
                IList<SearchCustomer_Result> custList = new List<SearchCustomer_Result>();
                custList = (IList<SearchCustomer_Result>)context.SearchCustomer(name, contact, email).ToList();
                if (custList.Count > 0)
                {
                    returnedList = new List<IUserDTO>();
                    foreach (var user in custList)
                    {
                        IUserDTO userDTO = (IUserDTO)DTOFactory.Instance.Create(DTOType.UserDTO);
                        EntityDataModel.EntityConverter.FillDTOFromEntity(user, userDTO);
                        returnedList.Add(userDTO);
                    }
                }
            }
            return returnedList;

        }


    }
}
