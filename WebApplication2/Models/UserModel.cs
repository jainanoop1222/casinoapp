using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public int Balance { get; set; }
        public int Blocked { get; set; }
        public string UniqueID { get; set; }
    }
}