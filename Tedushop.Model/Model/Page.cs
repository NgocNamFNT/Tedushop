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
    [Table("Page")]
    public class Page: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [Required]
        [MaxLength(256)]
        public string Content { set; get; }
        [Column(TypeName ="Varchar")]
        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }
    }
}
