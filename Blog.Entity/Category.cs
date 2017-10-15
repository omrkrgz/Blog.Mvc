using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity
{
    [Table("Category")]
   public class Category:MyEntityBase
    {
        [Required] [StringLength(40)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Descreption { get; set; }

        public virtual List<Content> Contents { get; set; }
    }
}
