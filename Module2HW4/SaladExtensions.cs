using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4
{
    public static class SaladExtensions
    {
        public static EdibleVegetable[] FindBySearchTerm(this Salad salad, string searchTerm)
        {
            var foundVegetables = new EdibleVegetable[salad.GetVegetables().Length];
            int foundCount = 0;
            foreach (var vegetable in salad.GetVegetables())
            {
                if (vegetable.Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase)) {
                    foundVegetables[foundCount++] = vegetable;
                }
            }
            Array.Resize(ref foundVegetables, foundCount);
            return foundVegetables;
        }

        public static EdibleVegetable[] FindByCalorieRange(this Salad salad, int minCalories, int maxCalories)
        {
            EdibleVegetable[] foundVegetables = new EdibleVegetable[salad.GetVegetables().Length];
            int foundCount = 0;
            foreach (var vegetable in salad.GetVegetables())
            {
                if (vegetable.Calories >= minCalories && vegetable.Calories <= maxCalories)
                {
                    foundVegetables[foundCount++] = vegetable;
                }
            }
            Array.Resize(ref foundVegetables, foundCount);
            return foundVegetables;
        }
    }
}