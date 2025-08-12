using System;


namespace _07_TempoDownload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mb = 0, mbps = 0;
            decimal tempoMinuto, tempoSegundo;
            bool numeroValido = false, velocidadeValida = false;

            while (!numeroValido || mb <= 0 ) {
               
                    Console.WriteLine("Informe o tamanho do arquivo:");
                    numeroValido = int.TryParse(Console.ReadLine(), out mb);
                if (!numeroValido || mb <= 0)    
                    Console.WriteLine("Numero invalido");
                
            }

            while (!velocidadeValida || mbps <= 0) {
                Console.WriteLine("Informe a velocidade da internet :");
                velocidadeValida = int.TryParse(Console.ReadLine(), out mbps);
                if (!velocidadeValida || mbps <= 0)
                    Console.WriteLine("Numero invalido");
            }

             
            tempoSegundo = (mb * 8) / mbps;
            tempoMinuto = tempoSegundo / 60;

            Console.WriteLine("Tempo aproximado de download: {0:F2} minutos", tempoMinuto);
        }
    }
}
