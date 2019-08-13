using System;
using Checkout.Engine;
using Xunit;

namespace Checkout.Tests
{
    public class ScannerTests
    {
        private readonly Scanner _checkout;

        public ScannerTests()
        {
            _checkout = new Scanner();
        }

        [Fact]
        public void GivenAnEmptyCart_WhenCalculatingTotal_Return0 ()
        {
            var cart = string.Empty;
            var expectedTotal = _checkout.TotalPrice(cart);

            Assert.Equal(0, expectedTotal);
        }

        [Theory]
        [InlineData("A", 50)]
        [InlineData("B", 30)]
        [InlineData("C", 20)]
        [InlineData("D", 15)]
        public void GivenAnCartContainingSingleItems_WhenCalculatingTotal_ReturnExpectedPrice (string items, int expected)
        {
            var cart = items;
            var expectedTotal = _checkout.TotalPrice( cart );

            Assert.Equal( expected , expectedTotal );
        }

        [Fact]
        public void GivenMoreThanOneItems_WhenCalculatingTotal_ReturnSumOfItemPrices()
        {
            var cart = "AB";
            var expectedTotal = _checkout.TotalPrice(cart);

            Assert.Equal(80, expectedTotal);
        }
    }
}
