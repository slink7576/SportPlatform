using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Domain.Entities
{
    public class Worker
    {
        public Worker()
        {
            this.WorkHistories = new HashSet<WorkHistory>();
            this.Courses = new HashSet<Course>();
            this.Certificates = new HashSet<Certificate>();
            this.TrainingPrograms = new HashSet<TrainingProgram>();
            this.FoodPrograms = new HashSet<FoodProgram>();
        }
        public int WorkerId { get; set; }
        public string About { get; set; }
        public string WorkPlace { get; set; }
        public string WorkTitle { get; set; }
        public string WorkDescription { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<WorkHistory> WorkHistories { get; private set; }
        public ICollection<Course> Courses { get; private set; }
        public ICollection<FoodProgram> FoodPrograms { get; private set; }
        public ICollection<Certificate> Certificates { get; private set; }
        public ICollection<TrainingProgram> TrainingPrograms { get; private set; }
    }
}
