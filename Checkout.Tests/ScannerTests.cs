using System;
using Checkout.Engine;
using Xunit;

namespace Checkout.Tests
{
    public class ScannerTests
    {
        
        [Fact]
        public void GivenAnEmptyCart_WhenCalculatingTotal_Return0 ()
        {
            var cart = string.Empty;
            var checkout = new Scanner();
            var expectedTotal = checkout.TotalPrice(cart);

            Assert.Equal(0, expectedTotal);
        }

        [Theory]
        [InlineData("A", 50)]
        [InlineData("B", 30)]
        [InlineData("C", 20)]
        [InlineData("D", 15)]
        public void GivenAnCartContainingItemA_WhenCalculatingTotal_Return50 (string items, int expected)
        {
            var cart = items;
            var checkout = new Scanner();
            var expectedTotal = checkout.TotalPrice( cart );

            Assert.Equal( expected , expectedTotal );
        }
    }
}
