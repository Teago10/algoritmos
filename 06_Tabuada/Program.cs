using System;


namespace _06_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int numero;
            int resultado;

            Console.WriteLine("Digite um numero: ");
            numero = int.Parse(Console.ReadLine() );
            

            while (contador <= 10) 
            {
                resultado = numero * contador;
                Console.WriteLine("{0} x {1} = {2}", numero,contador, resultado);
                contador++;
            }

        }
    }
}
