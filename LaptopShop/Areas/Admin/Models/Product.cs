using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopShop.Areas.Admin.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int  Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string Screens { get; set; }
        public string Storage { get; set; }
        public string Operating_System { get; set; }
        public string battery { get; set; }
        public string Weight { get; set; }
        public string Graphics { get; set; }
        public string Configuration { get; set; }
        public string Average_Number_Stars { get; set; }
        public string Number_Of_Reviews { get; set; }
        public bool Status { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Cart> Carts { get; set; }
    }
}
