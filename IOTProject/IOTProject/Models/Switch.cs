using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IOTProject.Models
{
    public class Switch
    {
        [Key]
        public int ID { get; set; }
        public Boolean Defect1 { get; set; }
        public Boolean Defect3 { get; set; }
        public Boolean Defect2 { get; set; }
        public Boolean Defect4 { get; set; }
        public string status { get; set; }
        public DateTime Time { get; set; }
    }
}