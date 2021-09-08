using Omadiko.Database;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace Omadiko.WebApp.Models
{
    public class RegisterViewModel
    {
        //public ApplicationDbContext Context;
        //public RegisterRolesAcountViewModel(ApplicationDbContext context, RegisterViewModel register)
        //{
        //    Context = context;
        //    Register = register;
        //}
        //public IEnumerable Roles
        //{
        //    get
        //    {
        //        return Context.Roles.Where(u => !u.Name.Contains("Admin")).ToList();
        //    }
        //}


        [Required]
        [Display(Name = "UserRoles")]
        public string UserRoles { get; set; }

        [Required]        
        [StringLength(15, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }





        [Display(Name = "UserPhoto")]
        public byte[] UserPhoto { get; set; }



    }
}
