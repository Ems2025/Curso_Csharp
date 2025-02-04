namespace votacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em qual ano você nasceu?");
            int nasc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();// em branco, pula uma linha

            Console.WriteLine(voto(nasc)); //
        }

        static string voto(int ano)
        {
            DateTime dataatual = DateTime.Now;
            int anoAtual = dataatual.Year; //vai buscar o ano 
                                           //int mes = dataatual.Month; // vai buscar o Mês
                                           //int dia = dataatual.Day; // busca o dia 
                                           // int hora = dataatual.Hour;  // busca a hora 
                                           //int minuto = dataatual.Minute; // busca o minuto 
                                           // int segundo = dataatual.Second; // busca os segundos 
            int idade = anoAtual - ano;
            if (idade < 16)
            {
                return $"com {idade} anos: você não vota.";

            }
            else if (idade >= 18 && idade < 70)
            {
                return $"com {idade} anos : você vota.";
            }
            else
            {
                return $"com {idade} anos: seu voto é opcional.";

            }
        }
    }
}
