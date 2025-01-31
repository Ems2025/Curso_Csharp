namespace area_triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=====================");
            Console.WriteLine("Area do triangulo");     
            Console.WriteLine("=====================");
            Console.WriteLine();

            Console.Write("Digite a base do triangulo (m): ");
            double Base1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite a altura do triangulo (m): ");
            double Altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Areatriangulo(Base1, Altura);



        }

        static void Areatriangulo(double b, double A)
        {
            double area = (b * A) / 2;
            Console.WriteLine($"A area do triangulo de {b} x a base de {A} resulta em {area}");
        }
    }
}
