using System.Diagnostics.Tracing;

namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // O programa fica em formato de TABELA, com linhas e colinas 

            int[,] matriz = new int[4, 3]; // 4= LINHAS (INICIANDO SEMPRE DO ZERO,UM...) 3= COLUNAS (INICANDO SEMPRE DO ZERO,UM...)
            matriz[0, 0] = 10;
            matriz[0, 1] = 15;        //essa é a linha Zero 
            matriz[0, 2] = 20;

            matriz[1, 0] = 25;
            matriz[1,1] = 30;    // essa é a linha Um 
            matriz[1, 2] = 35;

            matriz[2, 0] = 40;
            matriz[2, 1] = 45;   // essa é a linha dois 
            matriz[2, 2] = 50;

            matriz[3, 0] = 55;
            matriz[3, 1] = 60;   // essa é a linha três
            matriz[3, 2] = 65;

            for (int i = 0; i < 4; i++) //  i= LINHA 
            {
                for (int j = 0; j < 3; j++)  // J= coluna
                {
                    Console.Write(matriz[i, j]+ " "); 
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine(matriz.GetLength(0));
            Console.WriteLine(matriz.GetLength(1));

        }
    }
}
