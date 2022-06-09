using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopShop.Areas.Admin.Models
{
    public class InvoiceDetail
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public Invoice Invoices { get; set; }
        public int ProductId { get; set; }
        public Product Products { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
