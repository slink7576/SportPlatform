using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Domain.Entities
{
    public class ClientTrainingProgram
    {
        public int ClientTrainingProgramId { get; set; }

        public int TrainingProgramId { get; set; }
        public TrainingProgram TrainingProgram { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

    }
}
