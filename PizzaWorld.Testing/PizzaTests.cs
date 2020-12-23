using PizzaWorld.Domain.Models;
using Xunit;
using PizzaWorld.Domain.Factories;

namespace PizzaWorld.Testing
{
    public class PizzaTests
    {
        [Fact]
        private void Test_MeatPizzaExists()
        {
            // arrange
            var sut = new MeatPizza();

            // act
            var actual = sut;

            // assert
            Assert.IsType<MeatPizza>(actual);
            Assert.NotNull(actual);
        }
        [Fact]
        private void Test_FourCheesePizzaExists()
        {
            // arrange
            var sut = new FourCheesePizza();

            // act
            var actual = sut;

            // assert
            Assert.IsType<FourCheesePizza>(actual);
            Assert.NotNull(actual);
        }
        [Fact]
        private void Test_PepperoniPizzaExists()
        {
            // arrange
            var sut = new PepperoniPizza();

            // act
            var actual = sut;

            // assert
            Assert.IsType<PepperoniPizza>(actual);
            Assert.NotNull(actual);
        }
        [Fact]
        private void Test_PizzaExists()
        {
            // arrange
            var sut = new VeggiePizza();

            // act
            var actual = sut;

            // assert
            Assert.IsType<VeggiePizza>(actual);
            Assert.NotNull(actual);
        }
        [Fact]
        private void Test_PizzaFactory_Works()
        {
            // arrange
            var sut = new GenericPizzaFactory();

            // act
            var actual = sut.Make<VeggiePizza>();

            // assert
            Assert.IsType<VeggiePizza>(actual);
            Assert.NotNull(actual);
        }
        [Fact]
        private void Test_Pizzas_Have_Names()
        {
            // arrange
            var sut = new MeatPizza();

            // act
            var actual= sut.Name;

            // assert
            Assert.True(actual == "Meat Pizza");
        }
        [Fact]
        private void Test_Pizzas_Have_Crust()
        {
            // arrange
            var sut = new MeatPizza();

            // act
            var actual= sut.Crust;

            // assert
            Assert.NotNull(actual);
        }
        [Fact]
        private void Test_Pizzas_Have_Size()
        {
            // arrange
            var sut = new MeatPizza();

            // act
            var actual= sut.Size;

            // assert
            Assert.NotNull(actual);
        }
        [Fact]
        private void Test_Pizzas_Have_Toppings()
        {
            // arrange
            var sut = new MeatPizza();

            // act
            var actual= sut.Toppings;

            // assert
            Assert.NotNull(actual);
        }
       
    }
}