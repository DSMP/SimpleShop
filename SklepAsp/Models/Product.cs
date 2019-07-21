using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SklepAsp.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ProductId { get; set; }
        public string Name { get; set; }
        public Decimal Cost { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public string Image { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
        public Product()
        {
            DateCreated = DateTime.UtcNow;
        }
    }
}