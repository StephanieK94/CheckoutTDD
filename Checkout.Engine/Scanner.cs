namespace Checkout.Engine
{
    public class Scanner
    {
        public int TotalPrice(string cart)
        {
            var cartItems = cart.ToCharArray();
            var total = 0;
            var countOfItemA = 0;

            foreach (var item in cartItems)
            {
                if (item.Equals('A'))
                {
                    countOfItemA++;
                    if (countOfItemA % 3 == 0) total += 30;
                    else total += 50;
                }
                if ( item.Equals( 'B' ) ) total += 30;
                if ( item.Equals( 'C' ) ) total += 20;
                if ( item.Equals( 'D' ) ) total += 15;
            }

            return total;

            // Next weeks focus - more on pricing rule strategy
        }
    }
}