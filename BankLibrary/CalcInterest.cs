using System;

namespace BankLibrary
{
    public class CalcInterest : ICalcInterest
    {
        public int Calculate(int Principle, int RateOfInterest, int Years)

        {
            int SimpleInterest = (Principle * RateOfInterest * Years) / 100;
            return SimpleInterest;
        }
    }
}
