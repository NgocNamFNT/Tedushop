using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tedushop.Model.Abstract;

namespace Tedushop.Model.Model
{
    [Table("Post")]
    public class Post:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [Column(TypeName ="varchar")]
        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }
        [Required]
        public string CategoryID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Image { set; get; }
        
        [MaxLength(500)]
        public string Description { set; get; }
        public string Content { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        public virtual PostCategorie PostCategorie { set; get; }


        

    }
}
