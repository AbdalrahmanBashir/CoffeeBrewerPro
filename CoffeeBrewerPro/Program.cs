using CoffeeBrewerPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeBrewerPro
{
    public class Program
    {
        public static void Main()
        {
            CoffeeMaker coffee = new("Keurig K-Cafe", 50, true, true);

            System.Console.WriteLine($"Machine brand is: {coffee.GetBrandName()}");
            System.Console.WriteLine($"Reservoir Capacity is: {coffee.GetCupSizeInOunces()}");
            System.Console.WriteLine($"Switch is: {coffee.GetIsTurnOnOrOff()}");
            System.Console.WriteLine($"Basket: {coffee.GetIsInserted()}");
            coffee.Mimic();

            System.Console.ReadLine();

        }
    }
}
