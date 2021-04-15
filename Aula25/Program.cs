using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula25
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula25, Encadeamento de estrutura condicional, tipo int
            //Jonas Valereo -  Técnico em Informática

            //Declarando a variavel tipo int

            int hora;

            //Declarando entrada de dado no console, método ReadLine

            Console.WriteLine("Digite a hora");
            hora = int.Parse(Console.ReadLine());

            //Declarando encadeamento estrutural condicionais composta

            if (hora < 12)
            {

                Console.WriteLine("Bom dia!!!");
                Console.WriteLine();
                Console.WriteLine("Teste de novo!!!");

            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!!!");
                Console.WriteLine();
                Console.WriteLine("Teste de novo!!!");

            }
            else
            {
                Console.WriteLine("Boa noite!!!");
                Console.WriteLine();
                Console.WriteLine("Teste de novo!!!");

            }

            //saida da aplicação, console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa
        }
    }
}
