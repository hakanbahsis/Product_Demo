﻿using System.ComponentModel.DataAnnotations;

namespace Web.UI.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Lütfen mail giriniz!")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen cinsiyet seçiniz")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Lütfen şifre giriniz!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare("Password",ErrorMessage = "Lütfen şifrelerin eşleştiğinden emin olunuz")]
        public string ConfirmPassword { get; set; }
    }
}
