using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcoesMatematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.Write("Digite um valor: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite outro valor: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            soma(n1, n2);
            divisao(n1, n2);
            multiplicacao(n1, n2);

            Console.Read();
            
        }
        public static void soma(int n1, int n2)
        {
            int resultado = n1 + n2;
            Console.WriteLine(n1 + " + " + n2 + " = " + resultado);
        }
        public static void divisao(int n1, int n2)
        {
            int resultado = n1 / n2;
            Console.WriteLine(n1 + " / " + n2 + " = " + resultado);
        }
        public static void multiplicacao (int n1, int n2)
        {
            int resultado = n1 * n2;
            Console.WriteLine(n1 + " x " + n2 + " = " + resultado);
        }
    }
}
