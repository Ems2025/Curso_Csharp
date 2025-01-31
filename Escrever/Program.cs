namespace Escrever
{
    internal class Program
    {
        static void Escrever(string texto)
        {
            int tam = texto.Length + 4;
            string Linha = new('*', tam);
            string textocentralizado = texto.PadLeft(tam - 2). PadRight(tam - 2);
            Console.WriteLine(Linha);
            Console.WriteLine(textocentralizado);
            Console.WriteLine(Linha);
        }
       
        static void Main(string[] args)
        {
            Escrever("Emily Michelle de Sousa");
            Console.WriteLine();
            Escrever("Curso C#");
            Console.WriteLine();
            Escrever("Eu amo bike s2");
            Console.WriteLine();



        }
    }
}
