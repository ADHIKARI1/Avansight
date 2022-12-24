using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Avansight.Domain.Models
{
    public class TreatmentGroup
    {
        [Key]
        public string TreatmentCode { get; set; }
        public string TreatmentName { get; set; }
        public string TreatmentColor { get; set; }
        public Patient Patient { get; set; }
    }
}
