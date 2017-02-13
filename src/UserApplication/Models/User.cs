using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UserApplication.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a username")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        public string PassWord { get; set; }

        [Required(ErrorMessage = "Please enter a phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter an email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a regular Email address")]
        public string Email { get; set; }
    }
}