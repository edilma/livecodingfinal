using System;

namespace LiveCodingFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int average = 250;
            int candy = 3;
            string weather = "clear";
            int Temperature = 50;
            double total = candy * average * IsCold(weather) * IsTemp(Temperature);



            Console.WriteLine($"you need to bye {total}");
        }
        private static  double IsCold(string weather)
        {
            double value = 1;
            if (weather == "clear")
            {
                value = 1.10;
                return value;
            }
            else
            {
                if (weather == "cloud")
                {
                    return value;
                }
                else
                {
                    if (weather == "raining")
                    {
                        value = 1.25;
                        return value;
                    }
                    else
                    {
                        value = 1.10;
                        return value; ;
                    }
                }
            }
        }
        private static double IsTemp(int temperature)
        {
            double value = 0;
            if (temperature == 40)
            {
                
                return value;
            }
            else
            {
                if (temperature == 50)
                {
                    value = 1.05;
                    return value;
                }
                else
                {
                    if (temperature == 60)
                    {
                        value = 1.20;
                        return value;
                    }
                    else
                    {
                        value = 1.20;
                        return value; ;
                    }
                }
            }
        }

    }
}
