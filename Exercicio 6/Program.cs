﻿namespace Exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final, n1 , n2 , n3, n4;
            string resultado;

            Console.Write("digite a primeira nota do aluno: ");
            n1 =  Convert.ToDouble(Console.ReadLine());

            Console.Write("digite a segunda nota do aluno: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite a terceira nota do aluno: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite a quarta nota do aluno: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            nota_final = (n1 + n2 + n3 + n4);

            



            if (nota_final >= 60)
            {
                if (nota_final >= 90)
                {
                    resultado = "Aprovado com louvor";
                }
                else
                {

                    resultado = "Aprovado";
                }
            }
            else if (nota_final >= 40)
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "Reprovado";
            }
            
            
            Console.WriteLine("Nota do aluno: {0} - Resultado: {1}", nota_final, resultado);




            
        }
    }
}
