using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        //override default values using data annotations
        [Required(ErrorMessage = "Please enter customer name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }

        [Required(ErrorMessage = "Please select membership type")]
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

    }
}