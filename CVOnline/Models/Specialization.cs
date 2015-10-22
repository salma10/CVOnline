using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CVOnline.Models
{
    public class Specialization
    {
        public int SpecializationId { get; set; }

        public string FieldsOfSpecialization { get; set; }

        public string Description { get; set; }

        public string ExtracurricularActivities { get; set; }

        public string LanguageProficiency { get; set; }

        public int PersonalInfoId { get; set; }

        [ForeignKey("PersonalInfoId")]
        public PersonalInformation PersonalInformation { get; set; }  
    }
}