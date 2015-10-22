using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CVOnline.Models
{
    public class PersonalInformation
    {
        public int PersonalInfoId { get; set; }

        public string FathersName { get; set; }

        public string MothersName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Nationality { get; set; }

        public string NationnalIdNo { get; set; }

        public string PresentAddress { get; set; }

        public string PermanentAddress { get; set; }

        public string CurrentLocation { get; set; }

        public int MobilePhone { get; set; }

        public int HomePhone { get; set; }

        public int OfficePhone { get; set; }

        public string Email { get; set; }

        public string AlternateEmail { get; set; }

        public string CareerObjective { get; set; }

        public string Specialualification { get; set; }

        public int PresentSalary { get; set; }

        public int ExpectedSalary { get; set; }

        public byte Image { get; set; }

        public ICollection<EmploymentHistory> EmploymentHistories { get; set; }

        public ICollection<Training> Trainings { get; set; }

        public ICollection<References> References { get; set; }

        public ICollection<Education> Educations { get; set; }

        public ICollection<ProfessionalQualification> ProfessionalQualifications { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public UserProfile UserProfile { get; set; }
    }
}