using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Domain.Entities
{
    public class TrainingProgram
    {
        public TrainingProgram()
        {
            this.Trainings = new HashSet<Training>();
        }
        public int TrainingProgramId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        public ICollection<Training> Trainings { get; private set; }
    }
}
