using System;
using System.ComponentModel.DataAnnotations;

namespace BackendProject.ViewModels.Account
{
	public class LoginVM
	{
  
        [Required]
        public string EmailOrUsername { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}

