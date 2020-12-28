using PizzaWorld.Domain.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class OrderTests
    {
        [Fact]
        private void Test_OrderExists()
        {
            // arrange
            var sut = new Order();

            // act
            var actual = sut;

            // assert
            Assert.IsType<Order>(actual);
            Assert.NotNull(actual);
        }
        [Fact]
        private void Test_Has_Total()
        {
            // arrange
            var sut = new Order();

            // act
            var actual = sut.Total;

            // assert
            Assert.True(actual.GetType() == typeof(int));
        }
        [Fact]
        private void Test_Has_Pizzas()
        {
            // arrange
            var sut = new Order();

            // act
            var actual = sut.Pizzas;

            // assert
            Assert.NotNull(actual);
        }
        [Fact]
        private void Test_Pizzas_Has_Count()
        {
            // arrange
            var sut = new Order();

            // act
            var actual = sut.Pizzas.Count;
            
            // assert
            Assert.True(actual < 50);
            Assert.NotNull(actual);
        }
     
    }
}