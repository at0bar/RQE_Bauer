using System;
using System.Collections.Generic;
using System.Text;

namespace xUnitTest_RQE_Test_wi19b066
{
    class calculator
    {

        private double result;

        public double Result
        {
            get { return result; }
        }

        public void sine(double n)
        {
            result = Math.Sin(n);
        }

        public void cosine(double n)
        {
            result = Math.Cos(n);
        }

        public void tangens(double n)
        {
            result = Math.Tan(n);
        }
    }
}
