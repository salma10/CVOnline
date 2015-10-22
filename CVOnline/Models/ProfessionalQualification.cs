using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CVOnline.Models
{
    public class ProfessionalQualification
    {
        public int ProfessionalQualificationId { get; set; }

        public string Certification { get; set; }

        public string Institute { get; set; }

        public string Location { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public int PersonalInfoId { get; set; }

        [ForeignKey("PersonalInfoId")]
        public PersonalInformation PersonalInformation { get; set; }    
    }
}