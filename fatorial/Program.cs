namespace fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool mostrar = false;
             
            Console.Write("Digite um número para calcular o fatorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Você deseja ver o cálculo detalhado? (s/n): ");
            string resp = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (resp == "s") { mostrar = true; }    

            Console.WriteLine(fatorial(numero, mostrar));
            

            


        }
        static int fatorial(int numero, bool show = false)
        {
            int f = 1;
            for (int i = numero; i > 0; i--)
                {
                if (show)
                {
                    Console.Write(i + "");
                    if (i > 1)
                    {
                        Console.Write("x ");

                    }
                    else
                    {
                        Console.Write("= ");
                    }

                }

                f *= i;
            
            }   
            return f;   

        }
            

    }
}
