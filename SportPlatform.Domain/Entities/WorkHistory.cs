using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Domain.Entities
{
    public class WorkHistory
    {
        public int WorkHistoryId { get; set; }
        public DateTime StartWork { get; set; }
        public DateTime EndWork { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
    }
}
