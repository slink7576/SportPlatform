using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Domain.Entities
{
    public class Client
    {
        public Client()
        {
            ClientTrainingPrograms = new HashSet<ClientTrainingProgram>();
            ClientFoodPrograms = new HashSet<ClientFoodProgram>();
        }

        public int ClientId { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<ClientTrainingProgram> ClientTrainingPrograms { get; private set; }
        public ICollection<ClientFoodProgram> ClientFoodPrograms { get; private set; }
    }
}
