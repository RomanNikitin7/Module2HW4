using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4
{
    internal class LeafyVegetable : EdibleVegetable
    {
        public LeafyVegetable(string name, int calories) : base(name, calories)
        {
        }

        public override int CompareTo(EdibleVegetable other)
        {
            return string.Compare(this.Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
}
