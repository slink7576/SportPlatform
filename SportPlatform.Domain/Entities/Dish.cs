using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Domain.Entities
{
    public class Dish
    {
        public Dish()
        {
            this.DishMenus = new HashSet<DishMenu>();
            this.DishIngridients = new HashSet<DishIngridient>();
        }
        public int DishId { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Calories { get; set; }

        public ICollection<DishMenu> DishMenus { get; private set; }
        public ICollection<DishIngridient> DishIngridients { get; private set; }
    }
}

