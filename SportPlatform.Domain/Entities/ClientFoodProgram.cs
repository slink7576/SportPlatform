using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Domain.Entities
{
    public class ClientFoodProgram
    {
        public int ClientFoodProgramId { get; set; }

        public int FoodProgramId { get; set; }
        public FoodProgram FoodProgram { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
