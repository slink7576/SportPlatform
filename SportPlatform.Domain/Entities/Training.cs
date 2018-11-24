using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Domain.Entities
{
    public class Training
    {
        public Training()
        {
            this.TrainingActions = new HashSet<TrainingAction>();
        }
        public int TrainingId { get; set; }
        public DateTime DayOfWeek { get; set; }
        public string Description { get; set; }

        public int TrainingProgramId { get; set; }
        public TrainingProgram TrainingProgram { get; set; }

        public ICollection<TrainingAction> TrainingActions { get; set; }

    }
}
