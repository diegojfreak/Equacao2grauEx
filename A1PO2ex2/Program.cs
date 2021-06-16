using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1PO2ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Equacao e1 = new Equacao(2.0, 3.0, 5.0);
            Equacao e2 = new Equacao(4.0, -5.0, 2.0);

            Console.WriteLine(e1 + " + " + e2 + " = " + (e1 + e2));

        }
    }

    public class Equacao
    {
        double a { get; set; }
        double b { get; set; }
        double c { get; set; }

        public Equacao(double valora, double valorb, double valorc)
        {
            a = valora;
            b = valorb;
            c = valorc;
        }

        public override string ToString()
        {
            if(b < 0 && c < 0)
            {
                return a + "x² - " + Math.Abs(b) + "x - " + Math.Abs(c); /* Se o segundo "x" e terceiro numero for negativo */
            } else if(c < 0)
            {
                return a + "x² + " + b + " - " + Math.Abs(c); /* Se apenas o terceiro valor for negativo */
            } else if(b < 0)
            {
                return a + "x² - " + Math.Abs(b) + "x + " + c; /* Se apenas o segundo "x" for negativo*/
            }
            else
            {
                return a + "x² + " + b + "x + " + c; /* Caso nenhum seja negativo, exceto o "x²" que permitira ser exibido o "-" */
            }
        }

        public static Equacao operator + (Equacao E1, Equacao E2)
        {
            return new Equacao(E1.a + E2.a, E1.b + E2.b, E1.c + E2.c); /* Sobrecarga do operador "+" */
        }

    }
}
