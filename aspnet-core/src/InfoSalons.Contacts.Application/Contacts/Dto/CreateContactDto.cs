using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InfoSalons.Contacts.Contacts.Dto
{
    [AutoMapTo(typeof(Contact))]
    public class CreateContactDto
    {
        [Required]
        [MaxLength(500)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(500)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(500)]
        public string Company { get; set; }

        [Required]
        [MaxLength(500)]
        public string JobTitle { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public bool AttendanceStatus { get; set; }
    }
}
