namespace Ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite a primeira nota:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a primeira nota:");
            num2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A media é {0}", (num1 + num2) / 2);



        }
    }
}
