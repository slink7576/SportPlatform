 using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Domain.Entities
{
    public class FoodProgram
    {
        public FoodProgram()
        {
            this.Menus = new HashSet<Menu>();
            this.ClientFoodPrograms = new HashSet<ClientFoodProgram>();
        }
        public int FoodProgramId { get; set; }
        public string Name { get; set; }

        public int SpecialistId { get; set; }
        public Specialist Specialist { get; set; }
        public ICollection<Menu> Menus { get; private set; }
        public ICollection<ClientFoodProgram> ClientFoodPrograms { get; private set; }
    }
}
