﻿namespace ModelClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Calculator
    {
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
