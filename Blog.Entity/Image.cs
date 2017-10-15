using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;


namespace Blog.Entity
{
    
    public class Image:MyEntityBase
    {
        public string Location { get; set; }

        public virtual Content Content { get; set; }
    }
}
