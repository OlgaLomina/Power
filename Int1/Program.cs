using System;
/*Write a program to calculate pow(x,n)
Given two integers x and n, write a function to compute xn. We may assume that x and n are small and overflow doesn’t happen.

Examples :

Input : x = 2, n = 3
Output : 8

Input : x = 7, n = 2
Output : 49
 * */
namespace Int1
{
    // that can work for float x and negative y 
    public class GFG
    {

        static float Power(float x, int y)
        {
            float temp;

            if (y == 0)
                return 1;
            temp = Power(x, y / 2);

            if (y % 2 == 0)
                return temp * temp;
            else
            {
                if (y > 0)
                    return x * temp * temp;
                else
                    return (temp * temp) / x;
            }
        }

        // Program to test function power  
        public static void Main()
        {
            float x = 2;
            int y = -7;

            Console.Write(Power(x, y));
        }
    }
}
