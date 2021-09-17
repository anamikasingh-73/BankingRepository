using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public interface ICalcInterest
    {
        public int Calculate(int Principle, int RateOfInterest, int Years);
    }
}
