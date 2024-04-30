namespace Module2HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LeafyVegetable spinach = new LeafyVegetable("Spinach", 23);
            LeafyVegetable spinach1 = new LeafyVegetable("Spinach", 31);
            LeafyVegetable lettuce = new LeafyVegetable("Lettuce", 15);
            RootVegetable carrot = new RootVegetable("Carrot", 41);
            RootVegetable potato = new RootVegetable("Potato", 77);
            BulbVegetable onion = new BulbVegetable("Onion", 40);

            Salad salad = new Salad(new EdibleVegetable[] { spinach, spinach1, lettuce, carrot, potato, onion });


            salad.SortByName();

            var foundVegetables = salad.FindBySearchTerm("spinach");
            Console.WriteLine("Found vegetables by search term:");
            foreach (var veg in foundVegetables)
            {
                Console.WriteLine(veg.Name + " " + veg.Calories);
            }

            var foundByCaloriesRange = salad.FindByCalorieRange(30, 50);
            Console.WriteLine("Found vegetables by calories:");
            foreach (var veg in foundByCaloriesRange)
            {
                Console.WriteLine(veg.Name + " " + veg.Calories);
            }
        }
    }
}
