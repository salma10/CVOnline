using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CVOnline.Models
{
    public class Training
    {
        public int TrainingId { get; set; }

        public string TrainingTitle { get; set; }

        public string TopicsCovered { get; set; }

        public string Institute { get; set; }

        public string Country { get; set; }

        public string Location { get; set; }

        public int TrainingYear { get; set; }

        public int Duration { get; set; }

        public int PersonalInfoId { get; set; }

        [ForeignKey("PersonalInfoId")]
        public PersonalInformation PersonalInformation { get; set; } 
         
    }
}