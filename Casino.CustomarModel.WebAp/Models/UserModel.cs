using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casino.CustomarModel.WebAp.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Emailid { get; set; }
        public int Balance { get; set; }
        public int Blocked { get; set; }
    }
}