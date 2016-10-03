using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PizzaDomain;
using PizzaStore.PizzaMakers;
using FluentAssertions;

namespace PizzaStore.Tests.PizzaMaker
{
    [TestClass]
    public class PapaGinosTests
    {
        private IPizzaMaker pizzaMaker;

        [TestInitialize]
        public void TestInitialize()
        {
            pizzaMaker = new PapaGinos();
        }

        [TestMethod]
        public void TakeOrder_WithSizeAndToppings_ShouldBeSuccessful()
        {
            // arrange
            var size = Size.Large;
            var toppings = new List<string>();

            // act
            Action action = () => pizzaMaker.TakeOrder(size, toppings);

            // assert
            action.ShouldThrow<Exception>().WithMessage("Pizza needs toppings!");
        }
    }
}
