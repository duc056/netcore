using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TsdNetCoreLab6_EF.Models
{
    [Table("TsdProduct")] 
    public class TsdProducts
    {
        public const int TSD_MAX_PRODUCT_NAME_LENGTH = 150;

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(TSD_MAX_PRODUCT_NAME_LENGTH, ErrorMessage = "Tên sản phẩm giới hạn 150 ký tự")]
        [Column(TypeName = "nvarchar(150)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Giá sản phẩm không được để trống")]
        public double Price { get; set; }

        public double? SalePrice { get; set; }

        public byte Status { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Danh mục sản phẩm không được để trống")]
        public int TsdCategoryId { get; set; } 
        [ForeignKey("TsdCategoryId")]
        public virtual TsdCategory TsdCategory { get; set; }
    }
}
