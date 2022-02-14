using System;

namespace Triangulos.Consoleapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, soma;
            string op ;

            do  {
                Console.WriteLine("Verificação dos tipo de triangulo \n");
                Console.Write("Digite o primeiro valor: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o terceiro valor: ");
                c = Convert.ToDouble(Console.ReadLine());
                soma = a + b;
                if (c < soma)
                {
                    if (a == b && b == c && c == a) Console.WriteLine("\nTriangulo Equilatero");
                    else if (a != b && b != c && c != a) Console.WriteLine("\nTriangulo Escaleno");
                    else Console.WriteLine("\nTriangulo Isósceles");
                }
                else Console.WriteLine("\nTriangulo invalido ");
             
                Console.WriteLine("\nDigite 's' se deseja verificar novamente? ");
                op = Console.ReadLine();
                Console.Clear();

            } while (op == "s");

        }
    }
}
