﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedushop.Model.Model
{
    [Table ("ProductTag")]
    public class ProductTag
    {
        [Key]
        public int ProductID { set; get; }
        [Key]
        [Column (TypeName ="varchar")]
        [MaxLength(256)]
        public int TagID { set; get; }
        [ForeignKey("ProductID")]
        public virtual Product Products { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tags { set; get; }
    }
}
