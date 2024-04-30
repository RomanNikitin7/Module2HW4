using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4
{
    public class Salad
    {
        private EdibleVegetable[] vegetables;

        public Salad(EdibleVegetable[] vegetables)
        {
            this.vegetables = vegetables;
        }

        public int CalculateTotalCalories()
        {
            int totalCalories = 0;
            foreach (var vegetable in vegetables)
            {
                totalCalories += vegetable.Calories;
            }
            return totalCalories;
        }

        // Method to access vegetables array
        public EdibleVegetable[] GetVegetables()
        {
            return vegetables;
        }

        public void SortByName()
        {
            Array.Sort(vegetables, new NameComparer());
        }

        public void SortByCalories()
        {
            Array.Sort(vegetables, new CaloriesComparer());
        }

        // Custom comparer class for sorting by name
        private class NameComparer : IComparer<EdibleVegetable>
        {
            public int Compare(EdibleVegetable x, EdibleVegetable y)
            {
                return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
            }
        }

        // Custom comparer class for sorting by calories
        private class CaloriesComparer : IComparer<EdibleVegetable>
        {
            public int Compare(EdibleVegetable x, EdibleVegetable y)
            {
                return x.Calories.CompareTo(y.Calories);
            }
        }
    }
}
