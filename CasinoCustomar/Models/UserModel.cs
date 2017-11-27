using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CasinoCustomar.Models
{
    public class UserModel
    {
        public int PersonID { get; set; }
        [RegularExpression(@"^[a-zA-z]+$", ErrorMessage = "Only Alphabets and spaces are permitted")]
        [Required]
        public string Name { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        [Range(1000000000, 9999999999, ErrorMessage = "Contact Number should be of 10 digits")] 
        [Required]
        public string Contact { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")] 
        [Required]
        public string Emailid { get; set; }
        public int Balance { get; set; }
        public int Blocked { get; set; }
        public string UniqueID { get; set; }
        public byte[] Image { get; set; }
    }
}