﻿using System.ComponentModel.DataAnnotations;

namespace Omadiko.WebApp.Models
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}