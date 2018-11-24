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
        }
        public int FoodProgramId { get; set; }
        public string Name { get; set; }

        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        public ICollection<Menu> Menus { get; private set; }

    }
}
