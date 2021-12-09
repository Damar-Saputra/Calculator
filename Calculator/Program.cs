using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double Tambah(double a, double b)
        {
            return a + b;
        }
        public double Kali(double a, double b)
        {
            return a * b;
        }
        public double Bagi(double a, double b)
        {
            return a / b;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            double a = Double.Parse(args[0]);
            double b = Double.Parse(args[1]);

            Calculator cc = new Calculator();

            double tb = cc.Tambah(a, b);
            double kl = cc.Kali(a, b);
            double bg = cc.Bagi(a, b);

            Console.WriteLine("Penjumlahan = {0}", tb);
            Console.WriteLine("Perkalian = {0}", kl);
            Console.WriteLine("Penjumlahan = {0}", bg);
        }
    }
}