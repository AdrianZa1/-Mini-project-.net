using System;

namespace CalculadoraApp
{
    public class CalculadoraImplementacion : ICalculadora
    {
        public double Sumar(double a, double b) => a + b;
        public double Restar(double a, double b) => a - b;
        public double Multiplicar(double a, double b) => a * b;

        public double Dividir(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("No se puede dividir para cero.");
            return a / b;
        }
    }
}
