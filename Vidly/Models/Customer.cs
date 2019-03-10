using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool isSubscribedToNewsLetter { get; set; }
        [Display(Name = "Membership Type")]
        public MembershipType MembershipType { get; set; } // Navigation property - relation between MembershipType and Customer
        public byte MembershipTypeId { get; set; } // Foreign key - Entity recognizes this 

        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }
    }
}