using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedushop.Model.Model
{
    [Table("PostTag")]
    public class PostTag
    {
        [Key]
        public int PostID { set; get; }
        [Key]
        [Column(TypeName ="varchar")]
        [MaxLength(256)]
        public int TagID { set; get; }
        [ForeignKey("PostID")]
        public virtual Post Posts { set; get; }
        [ForeignKey("TagId")]
        public virtual Tag Tags { set; get; }


    }
}
