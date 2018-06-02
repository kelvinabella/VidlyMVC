﻿using System;
using System.ComponentModel.DataAnnotations;

namespace VidlyMVC.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Min18YearsIfAMember]
        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }
    }
}