using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Entity.ViewModels
{
    public class LoginViewModel
    {
        [Required/*(ErrorMessage ="{0} alanı boş geçilemez)*/]
        public string Username { get; set; }

        public string Password { get; set; }

    }
}