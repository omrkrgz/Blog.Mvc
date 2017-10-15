using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity
{
   
  public class Liked
    {
        public int Id { get; set; }
        public virtual Content Content { get; set; }
        public virtual BlogUser LikeUser { get; set; }

    }
}
