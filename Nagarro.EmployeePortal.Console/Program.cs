using Casino.CustomarModel.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.CustomarModel.ConsoleApp
{
    public class Program
    {
        static void Main(String[] args)
        {
            IUserFacade userFacade = (IUserFacade)FacadeFactory.Instance.Create(FacadeType.UserFacade);
            IUserDTO userDTO = (IUserDTO)DTOFactory.Instance.Create(DTOType.UserDTO);
            OperationResult<IList<IUserDTO>> result = userFacade.GetAllUser();
            
            if(result.IsValid())
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.Balance);
                }
                Console.WriteLine("Completed");
            }
            else
            {
                Console.WriteLine("Failure");
            }
            Console.ReadLine();
        }
    }
}
