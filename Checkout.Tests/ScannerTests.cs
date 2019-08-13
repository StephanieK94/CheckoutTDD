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

        [Fact]
        public void GivenAnCartContainingItemA_WhenCalculatingTotal_Return50 ()
        {
            var cart = "A";
            var checkout = new Scanner();
            var expectedTotal = checkout.TotalPrice( cart );

            Assert.Equal( 50 , expectedTotal );
        }
    }
}
