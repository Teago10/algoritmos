using System;

namespace _04_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variavel
            // Sintaxe: tipo nomeVariavel = valor
            string nome = "Fulano de Tal";

            //Reatribuição de valor em uma variavel
            nome = "Beltrano";
            Console.WriteLine(nome);

            //Declaração de vetores
            //Sintaxe: tipo[] nomeVariavel = {valor1, valor2, valor3}
            string[] nomes = { "Fulano de Tal", "Beltrano", "Sicrano", "João", "Maria" };
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);
            

            //Loop FOR = para
            //for(indice; controle; incremento)
            // .Length - 
            for(int i = 0;i < nomes.Length; i++)
            {
                Console.WriteLine("{0}° Nome: {1}", i+1, nomes[i]);  //{0} substitui i+1, {1} substitui nomes[i]
            }
            //Impressão dos 100 primeiros numeros pares
            for (int i = 0; i <= 100; i+= 2)
            {
                Console.WriteLine("Número: {0}", i);
            }

            //Loop foreach
            // Sintaxe: foreach(variavel in vetor)
            foreach(string varNome in nomes)
            {
                Console.WriteLine("Nome: {0}", varNome);
            }
        }
    }
}
