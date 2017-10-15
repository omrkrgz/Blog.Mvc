using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity
{
     [Table("Comment")]
  public class Comment:MyEntityBase
    {
        
        public string Text { get; set; }

        public virtual BlogUser Owner { get; set; }
        public virtual Content Content { get; set; }

    }
}
