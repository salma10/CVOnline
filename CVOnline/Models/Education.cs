using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CVOnline.Models
{
    public class Education
    {
        public int EducationId { get; set; }

        public string LevelOfEducation { get; set; } 

        public string ExamDegreeTitle { get; set; }

        public string ConcentrationMajor { get; set; }

        public string InstituteName { get; set; }

        public int Result { get; set; }

        public string Scale { get; set; }

        public int  YearOfPassing { get; set; }

        public int  Duration { get; set; }

        public int PersonalInfoId { get; set; }

        [ForeignKey("PersonalInfoId")]
        public PersonalInformation PersonalInformation { get; set; }
    }
}