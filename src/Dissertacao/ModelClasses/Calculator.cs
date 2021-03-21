namespace ModelClasses
{
    using System;

    public class Calculator
    {
        public int? n1 { get; set; }
        public int? n2 { get; set; }
        public int Add(int? n1, int? n2)
        {
            CheckForNull(n1, n2);
            return n1.Value + n2.Value;
        }
        public int Subtract(int? n1, int? n2)
        {
            CheckForNull(n1, n2);
            return n1.Value - n2.Value;
        }
        public int Multiply(int? n1, int? n2)
        {
            CheckForNull(n1, n2);
            return n1.Value * n2.Value;
        }
        public int Divide(int? n1, int? n2)
        {
            CheckForNull(n1, n2);
            CheckDivisionZero(n2);
            return n1.Value / n2.Value;
        }
        private static void CheckForNull(int? n1, int? n2)
        {
            if (!n1.HasValue || !n2.HasValue)
                throw new ArgumentNullException();
        }
        private static void CheckDivisionZero(int? n2)
        {
            if (n2.Value == 0)
                throw new DivideByZeroException();
        }
    }
}
