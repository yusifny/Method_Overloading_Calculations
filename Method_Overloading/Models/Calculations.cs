using System;
namespace Method_Overloading.Models
{
	public class Calculations
	{
        #region Sum
            public int Sum(int a, int b)
            {
                return a + b;
            }
            public int Sum(int a, int b, int c)
            {
                return a + b + c;
            }
            public int Sum(int a, int b, int c, int d)
            {
                return a + b + c + d;
            }

            public int Sum(int a, int b, int c, int d, int e)
            {
                return a + b + c + d + e;
            }
        #endregion

        #region Minus
            public int Minus(int a, int b)
            {
                return a - b;
            }
            public int Minus(int a, int b, int c)
            {
                return a - b - c;
            }
            public int Minus(int a, int b, int c, int d)
            {
                return a - b - c - d;
            }
            public int Minus( int a, int b, int c, int d, int e)
            {
                return a - b - c - d - e;
            }
        #endregion

        #region Multiply

            public int Multiply(int a, int b)
            {
                return a * b;
            }
            public int Multiply(int a, int b, int c)
            {
                return a * b * c;
            }
            public int Multiply(int a, int b, int c, int d)
            {
                return a * b * c * d;
            }
            public int Multiply(int a, int b, int c, int d, int e)
            {
                return a * b * c * d * e;
            }

        #endregion

        #region Divide

            public double Divide(int a, int b)
            {
                return (double) a / b;
            }
            public double Divide(int a, int b, int c)
            {
                return (double) a / b / c;
            }
            public double Divide(int a, int b, int c, int d)
            {
                return (double) a / b / c / d;
            }
            public double Divide(int a, int b, int c, int d, int e)
            {
                return (double) a / b / c / d / e;
            }

        #endregion

    }
}

