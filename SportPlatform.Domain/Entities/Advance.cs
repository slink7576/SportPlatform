using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Domain.Entities
{
    public class Advance
    {
        public int AdvanceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int SpecialistId { get; set; }
        public Specialist Specialist { get; set; }
    }
}
