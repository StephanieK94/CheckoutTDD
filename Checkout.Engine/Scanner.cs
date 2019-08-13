namespace Checkout.Engine
{
    public class Scanner
    {
        public int TotalPrice(string cart)
        {
            if (cart.Contains('A')) return 50;
            return 0;
        }
    }
}