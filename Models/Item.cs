using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WishListBack.Models
{
    public class Item
    { 
        [Key]
        public string id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string title { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(300)")]
        public string description { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(300)")]
        public string imageUrl { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string category { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public int price { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public Boolean purchased { get; set; }

    }
}
