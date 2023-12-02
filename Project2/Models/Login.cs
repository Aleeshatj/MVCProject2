using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project2.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Enter the Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Enter the Password")]
        public string Password { get; set; }
        public string Msg { get; set; }
    }
}