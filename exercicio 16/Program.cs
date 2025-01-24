namespace exercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, opçao = 0;

            Console.WriteLine("digite o primeiro numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite o segundo numer");
            n2 = Convert.ToInt32(Console.ReadLine());

            while (opçao != 5)
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - somar ");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Novos numeros");
                Console.WriteLine("5 - Sair");
                opçao = Convert.ToInt32(Console.ReadLine());

                switch(opçao)
                {
                    case 1:
                        n3 = n1 + n2;
                        Console.WriteLine("A soma de {0} + {1} é igual a {2}.", n1, n2, n3);
                        break;

                    case 2:
                        n3 = n1 - n2;
                        Console.WriteLine("A Subtração de {0} - {1} é igual a {2}.", n1, n2, n3);
                        break;

                    case 3:
                        n3 = n1 * n2;
                        Console.WriteLine("A multiplicação de {0}  * {1} é igual a {2}.", n1, n2, n3);
                        break;

                    case 4:
                        Console.WriteLine("digite o primeiro numero: ");
                        n1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("digite o segundo numer");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        break;

                        case 5:
                        Console.WriteLine("saindo...");
                        break;

                        default:
                        Console.WriteLine("Opção invalida");
                        break ;




                }
            }



        }
    }
}
