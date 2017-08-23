using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyinviteMVC5WebApp.Models
{
    public class GuestResponse
    {
        [Display(Name="First Name")]
    [Required(ErrorMessage="First Name is required")]
        public string FirstName { get; set; }

         [Display(Name = "Last Name")]
         [Required(ErrorMessage = "Last Name is required")]
        public string LasttName { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        public string Phone{ get; set; }

        [Required(ErrorMessage = "Email is required")]
        
        public string Email{ get; set; }

        [Required, Range(14,80,ErrorMessage = "Age should be 14 to 80")]
        public int age { get; set; }

         [Display(Name = "Will Attens")]
    [Required(ErrorMessage="Please select one option")]
        public bool? WillAttend { get; set; }


    }
}