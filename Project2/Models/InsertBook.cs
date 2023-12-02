using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project2.Models
{
    public class InsertBook
    {
        [Required(ErrorMessage = "Enter the Name")]
        public string BName { get; set; }
        [Required(ErrorMessage = "Enter the Author Name")]
        public string BAuthor { get; set; }
        [Required(ErrorMessage = "Required")]
        public string BImage { get; set; }
        [Required(ErrorMessage = "Required")]
        public string BDescr { get; set; }
        [Required(ErrorMessage = "Required")]
        public string BPrice { get; set; }
        public string BStatus { get; set; }
        public string Msg { get; set; }
    }
}