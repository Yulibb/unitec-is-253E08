using System;

namespace Application253E08
{
    public class Figura253E08
    {
   
        public static double CalcularArea(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public static double CalcularPerimetro(double radio)
        {
            return 2 * Math.PI * radio;
        }

        public static double CalcularVolumen(double area, double altura)
        {
            return area*altura;
        }
    }
}
