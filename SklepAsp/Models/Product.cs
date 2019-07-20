using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SklepAsp.Models
{
    public class Product
    {
        [Key]
        public string ProductId { get; set; }
        public string Name { get; set; }
        public Decimal Cost { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public byte[] Photo { get; set; }
    }
}