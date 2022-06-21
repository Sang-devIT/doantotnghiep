using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopShop.Areas.Admin.Models
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Tên")]
        public string Name { get; set; }
        [DisplayName("Giá")]
        public int  Price { get; set; }
        [DisplayName("Tồn kho")]
        public int Stock { get; set; }
        [DisplayName("Ảnh")]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
      
        public int ProductTypeId { get; set; }
        [DisplayName("Loại sản phẩm")]
        public ProductType ProductType { get; set; }
        public string Cpu { get; set; }
        public string Ram { get; set; }
        [DisplayName("Màn hình")]
        public string Screens { get; set; }
        [DisplayName("Lưu trữ")]
        public string Storage { get; set; }
        [DisplayName("Hệ điều hành")]
        public string Operating_System { get; set; }
        [DisplayName("Pin")]
        public string battery { get; set; }
        [DisplayName("Trọng lượng")]
        public string Weight { get; set; }
        [DisplayName("Đồ họa")]
        public string Graphics { get; set; }
        public string Configuration { get; set; }
        [DisplayName("Số sao trung bình")]
        public string Average_Number_Stars { get; set; }
        [DisplayName("Số lượng đánh giá")]
        public string Number_Of_Reviews { get; set; }
        [DisplayName("Trạng thái")]
        public bool Status { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Cart> Carts { get; set; }
    }
}
