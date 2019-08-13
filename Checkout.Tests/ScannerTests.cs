using System;
using System.Collections.Generic;
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
            var expectedTotal = _checkout.TotalPrice( items );

            Assert.Equal( expected , expectedTotal );
        }

        [Theory]
        [InlineData("AB", 80)]
        [InlineData("CBDA", 115)]
        public void GivenMoreThanOneItem_WhenCalculatingTotal_ReturnSumOfItemPrices(string items, int expectedSumOfItems)
        {
            var expectedTotal = _checkout.TotalPrice(items);

            Assert.Equal(expectedSumOfItems, expectedTotal);
        }

        [Theory]
        [InlineData("AA", 100)]
        [InlineData("AAA", 130)]
        [InlineData("AAAA", 180)]
        [InlineData("AAAAA", 230)]
        [InlineData("AAAAAA", 260)]
        public void GivenMoreThanOneOfSameType_WhenCalculatingTotal_ReturnsSumOfPrices(string items, int expectedSumOfItems)
        {
            var expectedTotal = _checkout.TotalPrice( items );

            Assert.Equal( expectedSumOfItems , expectedTotal );
        }
    }
}
