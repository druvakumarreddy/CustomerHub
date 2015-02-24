using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleMVCdapper.Models
{
    public class Customerinfo
    {
        public long ID { get; set; }
        [Required(ErrorMessage = "Enter Customer Name")]
        [Display(Name = "Customer Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Select Gender")]
        [Display(Name = "Customer Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Enter Customer City/Town")]
        [Display(Name = "Customer City")]
        public string City { get; set; }
        [Required(ErrorMessage = "Enter Customer Mail_ID")]
        [Display(Name = "Customer Email_ID")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }
    }
}