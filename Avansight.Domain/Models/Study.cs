using System;
using System.Collections.Generic;
using System.Text;

namespace Avansight.Domain.Models
{
    public class Study
    {
        public int StudyId { get; set; }
        public string StudyIdentifier { get; set; }
        public string StudyName { get; set; }
        public string ProjectNumber { get; set; }
        public string Type { get; set; }
        public Patient Patient { get; set; }

    }
}
