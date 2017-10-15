using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity
{
    [Table("Content")]
   public class Content:MyEntityBase
    {
        [StringLength(50)]
        public string Title { get; set; }
        public string Text { get; set; }
        public bool IsDraft { get; set; }
        public int LikeCount { get; set; }

        public virtual Category Category { get; set; }
        public virtual BlogUser Owner { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Liked> Likes { get; set; }
        public List<Image> Images { get; set; }
    }
}
