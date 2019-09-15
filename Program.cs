using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_GameDev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            Console.Out.WriteLine("O Guia do GameDev das galáxias");

            Console.Out.WriteLine();

            //Exercício 2
            int Joao = 10;
            int Pedro = 15;
            int Maria = 17;
            int resultado = (Joao + Pedro + Maria)/3;
            
            Console.Out.WriteLine("Qual é a média das idades de João, Pedro e Maria? Sendo suas idades 10, 15 e 17 anos.");
            Console.Out.WriteLine("Resposta: A média das idades de João, Pedro e Maria é " + resultado);

            Console.Out.WriteLine();
            
            //Exercício 3
            string question = "Qual é o melhor canal do Youtube?";
            string awser = "O Guia do GameDev das Galáxias!";
            Console.Out.WriteLine(question);
            Console.Out.WriteLine(awser);

            Console.ReadLine();
        }
    }
}