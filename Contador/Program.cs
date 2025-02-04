namespace Contador // Programa que faz contagem progressiva e regressiva
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Contador(1, 10, 1);  // 1= inicio da contagem 10= final da contagem 1= quantos numeros ira pular na contagem de 1 em 1...
            Contador(10, 0, 2); //  10= inicio da contagem regressiva  0= final da contagem regressiva 2= pulando de 2 em 2...

            Escrever("Agora é sua vez de personalizar a contagem!");   // nova variavel para dar a opçao do usuario escolher o numero 
            Console.WriteLine("Digite a inicio: ");
            int ini = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a fim: ");
            int Final = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o passo: ");
            int pas = Convert.ToInt32(Console.ReadLine());

            Contador (ini, Final, pas); 
        }

        static void Contador(int inicio, int fim, int passo)
           
        {
            if (passo <0)
            {
                passo = -passo; 
            }

            Escrever($"Contagem de {inicio} até {fim} de {passo} em {passo}");
            Thread.Sleep(2000);
            

            if (inicio < fim)
            {
                int cont = inicio;
                while (cont <= fim)

                {
                    Console.Write($" {cont} ");  // contagem progressiva  (> soma + )
                    Thread.Sleep(500);
                     cont+= passo;

                }
                Console.WriteLine("fim");

            }
            else
            {
                int cont = inicio;
                while (cont >= fim)
                {
                    Console.Write($" {cont} ");   // contagem regressiva  ( < subtrai -)
                    Thread.Sleep(500);            // diminui a velocidade que os numeros aparecem na tela 
                    cont -= passo;

                }
                Console.WriteLine("fim");
            }


        }

        static void Escrever(string texto)
        {
            int tam = texto.Length + 4;
            string Linha = new('*', tam);
            string textocentralizado = texto.PadLeft(tam - 2).PadRight(tam - 2);
            Console.WriteLine(Linha);
            Console.WriteLine(textocentralizado);
            Console.WriteLine(Linha);
        }

    }
}
