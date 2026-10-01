using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TsdNetCoreLab6_EF.Models
{
    [Table("TsdCategory")]
    public class TsdCategory
    {
        public const int TSD_MAX_NAME_LENGTH = 100;

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(TSD_MAX_NAME_LENGTH)]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "tinyint")]
        public byte Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual ICollection<TsdProducts> TsdProducts { get; set; }
            = new List<TsdProducts>();
    }
}