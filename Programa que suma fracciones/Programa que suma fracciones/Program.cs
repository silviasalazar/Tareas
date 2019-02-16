using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_que_suma_fracciones
{
    class Frac
    {
        private int num;
        private int den;

        public Frac(int num, int den)
        {
            this.num = num;
            this.den = den;
        }
        public Frac()
        {
            num = 1;
            den = 1;
        }
        //SUMA
        public static Frac operator +(Frac x, Frac y)
        {
            Frac result = new Frac(x.num * y.den + x.den * y.num, x.den * y.den);
            return result;
        }
        //RESTA
        public static Frac operator -(Frac x, Frac y)
        {
            Frac result = new Frac(x.num * y.den - x.den * y.num, x.den * y.den);
            return result;
        }
        //MULTIPLICACIÓN
        public static Frac operator *(Frac x, Frac y)
        {
            Frac result = new Frac(x.num * y.num , x.den * y.den);
            return result;
        }
        //DIVISIÓN
        public static Frac operator /(Frac x, Frac y)
        {
            Frac result = new Frac(x.num * y.den , x.den * y.num);
            return result;
        }
        //IMPRIMIR
        public void imprime()
        {
            Console.WriteLine("{0}/{1}", num, den);
        }

        public decimal a_decimal()
        {
            return num / den;
        }
    }
    class Program
    {
        static void Main()
        {
            Frac a = new Frac(1,5);
            Frac b = new Frac();
            Frac c = a+b;
            Frac d = a - b;
            Frac e = a * b;
            Frac f = a / b;

            //IMPRIMIR DATOS
            a.imprime();
            b.imprime();
            c.imprime();
            d.imprime();
            e.imprime();
            f.imprime();

            Console.ReadKey();
        }

    }
}
    

