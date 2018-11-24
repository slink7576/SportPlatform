using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Domain.Entities
{
    public class DishIngridient
    {
        public int DishIngridientId { get; set; }

        public int DishId { get; set; }
        public Dish Dish { get; set; }

        public int IngridientId { get; set; }
        public Ingridient Ingridient { get; set; }
    }
}
