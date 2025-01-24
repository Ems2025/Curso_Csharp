namespace exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabuada;
            Console.WriteLine("Digite um numero");
            tabuada = Convert.ToInt32(Console.ReadLine());

            for (int i =0; i<=tabuada; i++) 

            {
                Console.WriteLine("{0} x {1}={2}", tabuada,i,tabuada*i);

            }
                    

        }
    }
}
