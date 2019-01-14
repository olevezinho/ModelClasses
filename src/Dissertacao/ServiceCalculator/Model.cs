namespace ServiceCalculator
{
    using System.Collections.Generic;
    using ModelClasses;

    public class Model : Calculator
    {
        public List<Calculator> Calculators { get; set; }
    }
}
