using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class Egg{ }
    public class Bacon { }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chef goes into the kitchen");
            CookingMethodAsync().Wait();
            Console.WriteLine("Chef serves the breakfast");
        }

        static async Task CookingMethodAsync()
        {
            Chef jay = new Chef();
            Task<Egg> eggTask = jay.CookEggAsync();
            Task<Bacon> baconTask = jay.CookBaconAsync();

            var breakfastTask = new List<Task> { eggTask, baconTask };
            while (breakfastTask.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTask);
                if (finishedTask == eggTask)
                {
                    Console.WriteLine("The Egg is ready!");
                }
                else if (finishedTask == baconTask)
                {
                    Console.WriteLine("The Bacon is ready!");
                }
                breakfastTask.Remove(finishedTask);
            }

            Console.WriteLine("Breakfast is prepared!");
        }
    }

    

    public class Chef
    {
        public async Task<Egg> CookEggAsync()
        {
            Console.WriteLine("Chef prepare the eggs");
            await Task.Delay(1000);
            Console.WriteLine("Chef boiling the water");
            await Task.Delay(2000);
            Console.WriteLine("Chef cooking the eggs");
            await Task.Delay(3000);
            Console.WriteLine("The eggs are cooked");
            return new Egg();
        }

        public async Task<Bacon> CookBaconAsync()
        {
            Console.WriteLine("Chef prepare the bacon from the fridge");
            await Task.Delay(3000);
            Console.WriteLine("Chef is preparing the seasonings");
            await Task.Delay(2000);
            Console.WriteLine("Chef is heating the Pan");
            await Task.Delay(3000);
            Console.WriteLine("Chef put oil into the pan");
            await Task.Delay(1000);
            Console.WriteLine("Chef is cooking the bacon");
            await Task.Delay(5000);
            Console.WriteLine("Bacon are cooked");
            return new Bacon();
        }
    }
}
