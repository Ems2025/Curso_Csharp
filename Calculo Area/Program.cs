namespace Calculo_Area // criar um programa para calcular a area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================");
            Console.WriteLine("Controle de terreno)");
            Console.WriteLine("=====================");
            Console.WriteLine();

            Console.Write("Digite a largura do terreno (m): ");
            double Largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o comprimento do terreno (m): ");
            double Comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Areaterreno(Largura, Comprimento);


        }

        // metodo para calcular o terreno
        static void Areaterreno(double l, double c)
        {
            double a = l * c;
            Console.WriteLine($"A area do terreno de {l}m x {c}m é de {a}m².");
        }
    }
}
