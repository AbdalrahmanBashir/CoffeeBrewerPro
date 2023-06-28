using Xunit;


namespace CoffeeBrewerPro.Test
{
    public class CoffeeMakerTests
    {
        private readonly CoffeeMaker coffeeMaker;
        private readonly StringWriter outputWriter;

        public CoffeeMakerTests()
        {
            coffeeMaker = new CoffeeMaker();
            outputWriter = new StringWriter();
            Console.SetOut(outputWriter);
        }

        [Fact]
        public void Mimic_ShouldBrewCoffee_WhenSwitchAndBasketAreInCorrectPosition()
        {
            // Arrange
            coffeeMaker.SetIsTurnOnOrOff(true);
            coffeeMaker.SetIsInserted(true);
            coffeeMaker.SetCupSizeInOunces(7.00);

            // Act
            coffeeMaker.Mimic();

            // Assert
            Assert.Contains("Brewing coffee using: 7 ounces of water.", outputWriter.ToString());
        }

        [Fact]
        public void Mimic_ShouldNotBrewCoffee_WhenSwitchIsOff()
        {
            // Arrange
            coffeeMaker.SetIsTurnOnOrOff(false);
            coffeeMaker.SetIsInserted(true);
            coffeeMaker.SetCupSizeInOunces(8.0);

            // Act
            coffeeMaker.Mimic();

            // Assert
            Assert.Contains("Cannot brew coffee!!! BASKET: True SWITCH: False.", outputWriter.ToString());
        }

        [Fact]
        public void Mimic_ShouldNotBrewCoffee_WhenBasketIsNotInserted()
        {
            // Arrange
            coffeeMaker.SetIsTurnOnOrOff(true);
            coffeeMaker.SetIsInserted(false);
            coffeeMaker.SetCupSizeInOunces(8.0);

            // Act
            coffeeMaker.Mimic();

            // Assert
            Assert.Contains("Cannot brew coffee!!! BASKET: False SWITCH: True.", outputWriter.ToString());
        }

        [Fact]
        public void Mimic_ShouldNotBrewCoffee_WhenSwitchAndBasketAreNotInCorrectPosition()
        {
            // Arrange
            coffeeMaker.SetIsTurnOnOrOff(false);
            coffeeMaker.SetIsInserted(false);
            coffeeMaker.SetCupSizeInOunces(8.0);

            // Act
            coffeeMaker.Mimic();

            // Assert
            Assert.Contains("Cannot brew coffee!!! BASKET: False SWITCH: False.", outputWriter.ToString());
        }
        [Fact]
        public void Dispose()
        {
            outputWriter.Dispose();
        }
    }
}
