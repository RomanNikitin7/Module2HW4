using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4
{
    public class RootVegetable : EdibleVegetable
    {
        public RootVegetable(string name, int calories) : base(name, calories)
        {
        }

        public override int CompareTo(EdibleVegetable other)
        {
            return this.Calories.CompareTo(other.Calories);
        }
    }
}
