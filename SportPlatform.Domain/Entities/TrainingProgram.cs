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
            this.ClientTrainingPrograms = new HashSet<ClientTrainingProgram>();
        }
        public int TrainingProgramId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int SpecialistId { get; set; }
        public Specialist Specialist { get; set; }
        public ICollection<Training> Trainings { get; private set; }
        public ICollection<ClientTrainingProgram> ClientTrainingPrograms { get; private set; }
    }
}
