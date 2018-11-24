using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Domain.Entities
{
    public class Menu
    {
        public Menu()
        {
            this.DishMenus = new HashSet<DishMenu>();
        }
        public int MenuId { get; set; }
        public DateTime Time { get; set; }
        public string Description { get; set; }

        public int FoodProgramId { get; set; }
        public FoodProgram FoodProgram { get; set; }
        public ICollection<DishMenu> DishMenus { get; private set; }
    }
}
