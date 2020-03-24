﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }
        [Required]
        public int CategoryID { set; get; }
        [MaxLength(256)]
        public string Image { set; get; }
        //public decimal? PromotionPrice { set; get; }
        //public int? Warranty { set; get; }
        //public decimal Price { set; get; }
        public string Content { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }
        //public virtual IEnumerable<PostTag> PostTags { set; get; }

        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { set; get; }
    }
}