using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Omadiko.WebApp.Models.RoleViewModel
{
    public class CreateRoleViewModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string name { get; set; }
    }
}