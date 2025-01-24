namespace eercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double casa, salario, anospagando, prestaçaomensal, mesesemprestimo;
            

            Console.WriteLine("Informe o valor da casa");
            casa =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Infome o seu salario");
            salario = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Infome em quantos anos quer pagar");
            anospagando = Convert.ToInt32(Console.ReadLine());

            mesesemprestimo = anospagando * 12;

            prestaçaomensal = casa / mesesemprestimo;

            if (prestaçaomensal < salario * 0.30)
            {
                Console.WriteLine("Emprestimo aceito");
                Console.WriteLine("prestação: {0}", mesesemprestimo);
                Console.WriteLine("Valor: {0} mensais", prestaçaomensal);
            }
            else
            {
                Console.WriteLine("emprestimo negado");
                Console.WriteLine("O valor das prestaçoes ultrapassa 30% do seu salario");

            }




            

            

            
            
          
        }
    }
}
