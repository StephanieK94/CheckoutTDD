using System;
using Xunit;

namespace Checkout.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GivenAnEmptyCart_WhenCalculatingTotal_Return0 ()
        {
            var cart = string.Empty;
            var checkout = new Scanner();
            var expectedTotal = checkout.TotalPrice(cart);

            Assert.Equal(0, expectedTotal);
        }
    }

    public class Scanner
    {
        public int TotalPrice(string cart)
        {
            return 0;
        }
    }
}
