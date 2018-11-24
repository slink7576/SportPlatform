using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Domain.Entities
{
    public class TrainingAction
    {
        public int TrainingActionId { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int Repeats { get; set; }
        public string Description { get; set; }

        public int TrainingId { get; set; }
        public Training Training { get; set; }
    }
}
