using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Domain.Entities
{
    public class Certificate
    {
        public int CertificateId { get; set; }
        public string Name { get; set; }
        public DateTime AchieveDate { get; set; }
        public string CertificateUrl { get; set; }

        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
    }
}
