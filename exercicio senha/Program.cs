namespace exercicio_senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123"; //senha correta
            string senhaDigitada; // senha digitada ´pelo usuario
            int tentativas = 0;  //contador de tentativas
           //loop para solicitar a senha ao usuario
            do
            {
                Console.Clear(); 
                Console.Write("Digite a senha: ");
                senhaDigitada = Console.ReadLine();
                tentativas++; // incrementa o contador de tentativas

                //verifica se a senha digitada é diferente da senha correta
                if (senhaDigitada != senha && tentativas < 3)
                {
                    Console.WriteLine("Senha incorreta!");
                    Console.WriteLine("você tem ainda" + (3 - tentativas) + "tentativa(s)");
                    Console.ReadKey();
                }
                else  if (senhaDigitada != senha && tentativas == 3)    
                {
                    Console.WriteLine("Senha incorreta! Seu acesso está bloqueado!");
                    return;
                }
            } while (senhaDigitada != senha);

            Console.Clear() ;
            Console.WriteLine("Senha correta! - Tentativas:" + tentativas);

           

            
             
        }
    }
}
