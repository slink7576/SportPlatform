using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Domain.Entities
{
    public class Ingridient
    {
        public Ingridient()
        {
            this.DishIngridients = new HashSet<DishIngridient>();
        }
        public int IngridientId { get; set; }
        public string Name { get; set; }
        public ICollection<DishIngridient> DishIngridients { get; private set; }
    }
}
