using System;
using System.Linq;

namespace _05_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criação de um vetor para armazenamento de 100 elementos
            //string[] nomews = {"Fulano", "Beltrano", "Sicrano"}
            string[] nomes = new string[100];
            string continuar = "S";
            //Será meu indice para atribuição no vetor
            int contador = 0;

            //Loop while
            //Sintaxe: while(expressão booleana(verdadeiro ou falso) )
            while(continuar.ToUpper() == "S") 
            { 
                Console.WriteLine("Digite o {0}° nome: ", contador+1);
                //Append: adiciona um metodo no vetor
                nomes[contador] = Console.ReadLine();

                //Incrementar o contador
                contador++;
                Console.WriteLine("Deseja continuar? (S/N): ");
                continuar = Console.ReadLine();
            }
            foreach (string str in nomes) 
            {
                if (str != null)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
