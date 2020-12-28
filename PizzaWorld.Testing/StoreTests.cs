using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class StoreTests
    {
        [Fact]
        private void Test_StoreExists()
        {
            // arrange
            var sut = new Store();

            // act
            var actual = sut;

            // assert
            Assert.IsType<Store>(actual);
            Assert.NotNull(actual);
        }
        [Fact]
        private void Test_StoreOrdersExists()
        {
            // arrange
            var sut = new Store();

            // act
            
            var actual = sut.Orders;


            // assert
            
            Assert.NotNull(actual);
        }
        [Fact]
        private void Test_StoreRevExists()
        {
            // arrange
            var sut = new Store();

            // act
            var actual = sut.Revenue;

            // assert
            Assert.IsType<int>(actual);
            Assert.NotNull(actual);
        }
    
    }
}