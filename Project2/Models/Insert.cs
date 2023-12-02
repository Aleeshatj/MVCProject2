using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project2.Models
{
    public class Insert
    {
        [Required(ErrorMessage = "Enter the name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter the Phone Number")]
        public string Phone { get; set; }

        [EmailAddress(ErrorMessage = "Enter valid address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter the Username")]
        public string Username { get; set; }
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password mismatch")]
        public string ConfirmPassword { get; set; }
        public string Msg { get; set; }
    }
}