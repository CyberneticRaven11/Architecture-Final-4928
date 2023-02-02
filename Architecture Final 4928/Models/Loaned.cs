using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Architecture_Final_4928.Models
{
    public class Loaned
    {
        public List<Client> Clients { get; set; }
        public Book Books { get; set; }
        public int SelectedClientId { get; set; }
    }
}