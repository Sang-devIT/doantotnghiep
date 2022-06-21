using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopShop.Areas.Admin.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        [DisplayName("Sản phẩm")]

        public Product Product { get; set; }
        public int UserId { get; set; }
        [DisplayName("Người dùng")]
        public User User { get; set; }
        [DisplayName("Số sao")]
        public int Rating { get; set; }
        [DisplayName("Nội dung")]
        public string Content { get; set; }
        [DisplayName("Ngày đánh giá")]
        public DateTime PublishDate { get; set; }
    }
}
