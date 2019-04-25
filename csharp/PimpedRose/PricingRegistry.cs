using System;

namespace PimpedRose
{
    public class PricingRegistry
    {
        public double GetPrice(Item i)
        {
            return new Random().NextDouble() * 100.0;
        }
    }

}
