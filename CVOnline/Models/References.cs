using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CVOnline.Models
{
    public class References
    {
        public int ReferencesId { get; set; }

        public string Name { get; set; }

        public string Organization { get; set; }

        public string Designation { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Relation { get; set; }

        public int PhoneOffice { get; set; }

        public int PhoneResidence { get; set; }
        
        public int Mobile { get; set; }

        public int PersonalInfoId { get; set; }

        [ForeignKey("PersonalInfoId")]
        public PersonalInformation PersonalInformation { get; set; }        
    }
}