using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CVOnline.Models
{
    public class EmploymentHistory
    {
        public int EmploymentHistoryId { get; set; }

        public string CompanyName { get; set; }

        public string CompanyBusiness { get; set; }

        public string CompanyLocation { get; set; }

        public string Department { get; set; }

        public string PositionHeld { get; set; }

        public string Responsibilities { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public int PersonalInfoId { get; set; }

        [ForeignKey("PersonalInfoId")]
        public PersonalInformation PersonalInformation { get; set; }      
    }
}