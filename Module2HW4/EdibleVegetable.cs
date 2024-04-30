using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4
{
    public abstract class EdibleVegetable : IVegetable, IComparable<EdibleVegetable>
    {
        public string Name {  get; set; }

        public int Calories { get; set; }
        public EdibleVegetable(string name, int calories)
        {
            Name = name;
            Calories = calories;
        }

        public abstract int CompareTo(EdibleVegetable other);
    }
}
