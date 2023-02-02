using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Architecture_Final_4928.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Author { get; set; }

        public string Photo { get; set; }

        [Display(Name= "Year of Publishing")]
        public int Year { get; set; }

        public virtual ICollection<Client> Clients { get;}

    }
}