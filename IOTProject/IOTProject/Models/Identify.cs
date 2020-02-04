using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IOTProject.Models
{
    public class Identify
    {
        [Key]
        public int IdentifyID { get; set; }
        public string DefectID { get; set; }
        public string BeltID { get; set; }
        public DateTime IdentifiedTime { get; set; }
    }
}