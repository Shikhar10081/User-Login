using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo_DB.Model
{
    [Table("Users")]
    public class User
    {
        [Required]
        [Key] 
        public int UserId { get; set; }

        [Required(ErrorMessage ="Password cant empty")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Re_Password cant empty")]
        [Display(Name ="Confirm Passward")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string Retype_Password { get; set; }


        [Required(ErrorMessage = "Email cant empty")]
        [EmailAddress(ErrorMessage = "Invalid email address")]


        public String Email { get; set; }

        [Range(18,80,ErrorMessage ="Age Must be Greater than 18")]
        public int Age { get; set; }

        public string Country { get; set; }



    }

}
