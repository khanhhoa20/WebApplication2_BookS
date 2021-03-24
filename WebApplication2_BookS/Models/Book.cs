using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication2_BookS.Models
{
    public class Book
    {
        [DisplayName("ISBN")]
        public string BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Edition { get; set; }
        public int PublishYear { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

    }
}