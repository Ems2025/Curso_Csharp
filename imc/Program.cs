namespace imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu Peso");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua altura em metros");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine($"Seu IMC é {imc}");  //F2= Reduz duas casas decimais 

            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso");

            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                Console.WriteLine("Peso normal ");
            }
            else if (imc >= 25 && imc < 29.9)
            {
                Console.WriteLine("Você está com Sobrepeso");
            }
            else if (imc >= 30 && imc < 34.9)
            {
                Console.WriteLine("Você está com Obesidade grau 1");
            }
            else if (imc >= 35 && imc < 39.9)
            {
                Console.WriteLine("Você está com Obesidade grau 2");
            }
            else
            {
                Console.WriteLine("Você está com Obesidade grau 3");
            }




        }
    }
}
