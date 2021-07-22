using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasicWebAppMVC.Models
{
    public class User
    {
        public int Id { get; set; }

        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Invalid Name (Letters and Spaces only)")]
        [MaxLength(100)]
        [Required(ErrorMessage = "Please enter Name")]
        public string Name { get; set; }

        [RegularExpression(@"^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+[.])+[a-z]{2,5}$", ErrorMessage = "Invalid Email")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Please enter Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter Job Title")]
        [MaxLength(50)]
        public string JobTitle { get; set; }

        [RegularExpression(@"^([A-Za-z]+(?: [A-Za-z]+)*),? ([A-Za-z]{2})$", ErrorMessage = "Invalid Location (ex: Little Rock, AR)")]
        [MaxLength(75)]
        [Required(ErrorMessage = "Please enter Location")]
        public string Location { get; set; }

        public User()
        {

        }
    }
}
