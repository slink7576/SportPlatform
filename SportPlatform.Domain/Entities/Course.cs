using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Domain.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public DateTime StartLearning { get; set; }
        public DateTime EndLearning { get; set; }
        public string Place { get; set; }
        public string DocumentUrl { get; set; }

        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
    }
}
