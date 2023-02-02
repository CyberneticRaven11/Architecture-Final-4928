using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Architecture_Final_4928.Models
{
    public class Client
    {

        [Key]
        [Display(Name = "Library ID")]
        public int id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(5,150,ErrorMessage ="Age must be between 5 and 150.")]
        public int Age { get; set; }

        


    }


}