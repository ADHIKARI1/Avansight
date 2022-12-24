using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Avansight.Domain.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }        
        public int StudyId { get; set; }
        public string TreatmentCode { get; set; }
        public Study Study { get; set; }
        public TreatmentGroup TreatmentGroup { get; set; }
    }

}
