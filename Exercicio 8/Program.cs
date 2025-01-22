using System.ComponentModel.Design;

namespace Exercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;

            Console.WriteLine("Programa para testar triangulos");   

            Console.WriteLine("Digite o valor do Lado A: ");
            ladoA=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite o valor do Lado B: ");
            ladoB =Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Digite o valor do Lado C: ");
            ladoC =Convert.ToInt32(Console.ReadLine());

            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoC))
            {
                Console.WriteLine("os valores informados formam um triangulo");
                if ((ladoA == ladoB) && (ladoB == ladoC))
                {
                    Console.WriteLine("E ele é um triangulo equilatero");
            
                }
                else if ((ladoA == ladoB) || (ladoA== ladoC) || (ladoB == ladoC))
                {
                    Console.WriteLine("e ele é um Triangulo Isósceles.");
                }
            }

            else
            {
                Console.WriteLine("e ele é um triangulo escaleno.");
            }



             


        }
    }
}
