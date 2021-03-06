﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedushop.Model.Model
{
    [Table("System")]
    public class SystemConfig
    {
        [Key]
        public int ID {set;get;}
        [Required]
        [Column (TypeName ="varchar")]
        [MaxLength(50)]
        public string Code { set; get; }
        [MaxLength(50)]
        public string ValuesString { set; get; }
        public int? ValuesInt { set; get; }
    }
}
