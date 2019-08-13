namespace Checkout.Engine
{
    public class Scanner
    {
        public int TotalPrice(string cart)
        {
            if (cart.Contains('A')) return 50;
            if (cart.Contains('B')) return 30;
            if (cart.Contains('C')) return 20;
            if (cart.Contains('D')) return 15;
            return 0;
        }
    }
}