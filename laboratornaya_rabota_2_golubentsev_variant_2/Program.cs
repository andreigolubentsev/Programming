using System;

namespace laboratornaya_rabota_2_golubentsev_variant_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, a1, b, b1, c, result1, result2;

            #region разбивка;

            a = (7 - 5.5) / 0.03;
            a1 = Math.Sqrt(3.05 + 3.62) * 4;
            b = Math.Pow((0.3 - 0.15), 0.25) * 1.5;
            b1 = (1.88 + 2.12) * 0.0125;
            c = Math.Pow((0.2), Math.Sqrt(3));

            #endregion;
            
            result1 = (Math.Sqrt(a / a1) - b / b1) * c;
            result2 = (Math.Sqrt(((7 - 5.5) / 0.03) / (Math.Sqrt(3.05 + 3.62) * 4)) - (Math.Pow((0.3 - 0.15), 0.25) * 1.5) / ((1.88 + 2.12) * 0.0125)) * (Math.Pow((0.2), Math.Sqrt(3)));
            Console.WriteLine("Выражение, посчитанное присвоением нескольким перменным: " + result1);
            Console.WriteLine("Выражение, посчитанное присвоением всего выражения одной переменной: " + result2);
            Console.ReadKey(true);




        }
    }
}
