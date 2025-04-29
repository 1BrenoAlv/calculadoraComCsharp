using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Calculator
    {
        public double Somar(double a, double b)
        {
            return a + b;
        }

        public double Subtrair(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Erro: Divisão por zero não permitida!");
                return 0;
            }
            return a / b;
        }

        public double Potenciar(double a, double b)
        {
            return Math.Pow(a, b);
        }

    }
}
