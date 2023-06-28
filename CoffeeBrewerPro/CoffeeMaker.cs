using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeBrewerPro
{
    public class CoffeeMaker
    {
        string brandName;
        double cupSizeInOunces;
        bool isInserted;
        bool isTurnOnOrOff;

        public CoffeeMaker()
        {
            // Default values when a new CoffeeMaker object is created
            brandName = "Keurig K-Cafe";
            cupSizeInOunces = 0.0;
            isInserted = false;
            isTurnOnOrOff = false;
        }
        public CoffeeMaker(string BrandName, int CupSizeInOunces, bool IsBasketInserted, bool IsTurnedOnOrOff)
        {
            brandName = BrandName;
            cupSizeInOunces = CupSizeInOunces;
            isInserted = IsBasketInserted;
            isTurnOnOrOff = IsTurnedOnOrOff;
        }

        // Setter methods to assign new values to the properties
        public void SetBrandName(string inputBrandName)
        {
            this.brandName = inputBrandName;
        }

        public void SetCupSizeInOunces(double CupSize)
        {
            this.cupSizeInOunces = CupSize;
        }

        public void SetIsInserted(bool trueOrFalse)
        {
            this.isInserted = trueOrFalse;
        }

        public void SetIsTurnOnOrOff(bool trueOrFalse)
        {
            this.isTurnOnOrOff = trueOrFalse;
        }

        // Getter methods to retrieve the values of the properties
        public string GetBrandName()
        {
            return brandName;
        }

        public double GetCupSizeInOunces()
        {
            return cupSizeInOunces;
        }

        public bool GetIsInserted()
        {
            return isInserted;
        }

        public bool GetIsTurnOnOrOff()
        {
            return isTurnOnOrOff;
        }

        public void Mimic()
        {
            System.Console.WriteLine(string.Empty);
            if (isTurnOnOrOff == true && isInserted != true)
            {
                // Comment: Unable to brew coffee if the switch is on but the coffee basket is not inserted.
                System.Console.WriteLine($"Cannot brew coffee!!! BASKET: {isInserted} SWITCH: {isTurnOnOrOff}.");
            }
            else if (isTurnOnOrOff != true && isInserted == true)
            {
                // Comment: Unable to brew coffee if the switch is off but the coffee basket is inserted.
                System.Console.WriteLine($"Cannot brew coffee!!! BASKET: {isInserted} SWITCH: {isTurnOnOrOff}.");
            }
            else if (isTurnOnOrOff != true && isInserted != true)
            {
                // Comment: Unable to brew coffee if both the switch and the coffee basket are not in the correct position.
                System.Console.WriteLine($"Cannot brew coffee!!! BASKET: {isInserted} SWITCH: {isTurnOnOrOff}.");
            }
            else if (isTurnOnOrOff == true && isInserted == true)
            {
                // Comment: Brewing coffee using the specified amount of water.
                System.Console.WriteLine($"Brewing coffee using: {cupSizeInOunces} ounces of water.");
            }
        }

    }
}
