using System;

namespace PimpedRose
{
    public class PricingRegistry
    {
        public double getPrice(Item i)
        {
            return new Random().NextDouble() * 100.0;
        }
    }

}
