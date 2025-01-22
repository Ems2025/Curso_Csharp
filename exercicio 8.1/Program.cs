using System.ComponentModel.Design;

namespace exercicio_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario1,aumento;

            Console.WriteLine("informe o valor do seu salario");
            salario1= Convert.ToDouble(Console.ReadLine());

            if (salario1 > 2500)
            {
                
                aumento = (salario1 * 0.05) + salario1;
                Console.WriteLine("O salario é {0}.", aumento);
            }

            else if (salario1 > 1250)
            {
                aumento = (salario1 * 0.1) + salario1;
                Console.WriteLine("O salario é {0}.",aumento);

            }

            else
            {
                aumento = (salario1 * 0.15) + salario1;
                Console.WriteLine("O salario é {0}.", aumento);
            }










               

             
           






             

        }
    }
}
