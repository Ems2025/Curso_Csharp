using System.Runtime.Serialization;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args) // metodo Main principal, faz rodar o codigo.
        {
            Saudaçao("Emily");
            Soma(10, 20);
        }
        static void Saudaçao(string nome)// COLOCAR SEMPRE DENTRO DA CHAVE INTERNAL CLASS PROGRAM. (metodo saudação)
        {
            Console.WriteLine($"ola {nome} seja bem vindo"); // Exibe uma mensagem de saudação 
        }  

        static void Soma(int a, int b) // metodo soma 
        {
            int resultado = a + b;
            Console.WriteLine($"A soma de {a} + {b}");  
           
        }
    }
}
