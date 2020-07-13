using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraApp
{
    public class ClassCalculadora
    {
        private double numero1;
        private double numero2;

        public double Numero1 { get => numero1; set => numero1 = value; }
        public double Numero2 { get => numero2; set => numero2 = value; }

        public double suma (double Numero1, double Numero2)
        {
            return (Numero1 + Numero2);
        }

        public double resta(double Numero1, double Numero2)
        {
            return (Numero1 - Numero2);
        }

        public double producto(double Numero1, double Numero2)
        {
            return (Numero1 * Numero2);
        }

        public double division(double Numero1, double Numero2)
        {
            if (Numero2 != 0)
            {
                return (Numero1 / Numero2);
            }
            else
            {
                return -9999;
            }
        }
    }
}
