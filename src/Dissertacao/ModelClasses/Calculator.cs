namespace ModelClasses
{
    using System;
    using log4net;

    public class Calculator
    {
        public int? n1 { get; set; }
        public int? n2 { get; set; }
        public int Add(int? n1, int? n2)
        {
            if (!n1.HasValue || !n2.HasValue)
            {
                throw new ArgumentNullException();
            }
            return n1.Value + n2.Value;
        }
    }
}
