using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfoSalons.Contacts.Contacts
{
    public class Contact : Entity<int>, IHasCreationTime, IHasModificationTime
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Company { get; set; }

        public string JobTitle { get; set; }

        public string Phone { get; set; }

        public bool AttendanceStatus { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationTime { get; set; }
    }
}
