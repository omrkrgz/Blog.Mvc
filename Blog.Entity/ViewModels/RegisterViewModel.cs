using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Entity.ViewModels
{
    public class RegisterViewModel
    {
        [DisplayName("Adı"),Required(ErrorMessage ="Adı alanı boş geçilemez"),StringLength(25,ErrorMessage ="Adı alanı max 25 karakter olmalıdır.")]
        public string Name { get; set; }

        [DisplayName("Soyadı"), Required(ErrorMessage = "Soyadı alanı boş geçilemez"), StringLength(30, ErrorMessage = "Soyadı alanı max 30 karakter olmalıdır.")]
        public string Surname { get; set; }

        [DisplayName("Kullanıcı adı"), Required(ErrorMessage = "Kullanıcı adı alanı boş geçilemez"), StringLength(30, ErrorMessage = "Kullanıcı adı alanı max 30 karakter olmalıdır.")]
        public string Username { get; set; }

        [DisplayName("Şifre"), Required(ErrorMessage = "Şifre alanı boş geçilemez"), StringLength(20, ErrorMessage = "Şifre alanı max 20 karakter olmalıdır."),DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Şifre Tekrar"), Required(ErrorMessage = "Şifre tekrar alanı boş geçilemez"), StringLength(20, ErrorMessage = "Şifre tekrar alanı max 20 karakter olmalıdır."), DataType(DataType.Password),Compare("Password",ErrorMessage ="Şifre ile Şifre tekrar alanı aynı olmalıdır.")]
        public string Repassword { get; set; }

        [DisplayName("Email"), Required(ErrorMessage = "Email alanı boş geçilemez"), StringLength(80, ErrorMessage = "Email alanı max 80 karakter olmalıdır."),EmailAddress(ErrorMessage ="Email adresi geçersiz.")]
        public string Email { get; set; }

    }
}