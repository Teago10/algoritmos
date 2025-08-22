using System;
using System.Linq;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        string cpf, apenasNumeros;

        Console.WriteLine("Informe seu CPF: ");
        cpf = Console.ReadLine();

        // Remove caracteres não numéricos
        apenasNumeros = Regex.Replace(cpf, @"\D", "");

        char[] vetorchar = apenasNumeros.ToCharArray();

        // Verifica se tem exatamente 11 dígitos
        if (vetorchar.Length != 11)
        {
            Console.WriteLine("CPF inválido");
            return;
        }

        /* Distinct() - Remove valores duplicados 
           Count() - Conta quantos valores únicos existem 
           Se existir apenas 1 valor único, todos são iguais */
        if (vetorchar.Distinct().Count() == 1)
        {
            Console.WriteLine("CPF inválido");
            return;
        }

        // Pega os 9 primeiros dígitos do CPF para calcular o 1º dígito
        string vetorcpf = apenasNumeros.Substring(0, 9);
        int soma = 0;

        // Calcula a soma do produto dos 9 primeiros dígitos pelos multiplicadores
        for (int i = 0; i < 9; i++)
        {
            soma += int.Parse(vetorcpf[i].ToString()) * (10 - i);
        }

        int resto = soma % 11;
        int digX;

        // Calcula o 1º dígito verificador usando if/else
        if (resto < 2)
        {
            digX = 0;
        }
        else
        {
            digX = 11 - resto;
        }

        soma = 0; // Zera a soma para calcular o 2º dígito
        int digY = 0;

        // Calcula a soma do produto dos 9 dígitos + 1º dígito verificador pelos multiplicadores
        for (int i = 0; i < 9; i++)
        {
            soma += int.Parse(vetorcpf[i].ToString()) * (11 - i);
        }
        soma += digX * 2; // Inclui o 1º dígito verificador com peso 2

        // Calcula o segundo dígito verificador usando if/else
        resto = soma % 11;
        if (resto < 2)
        {
            digY = 0;
        }
        else
        {
            digY = 11 - resto;
        }

        // Comparar os dígitos
        if (int.Parse(apenasNumeros[9].ToString()) == digX &&
            int.Parse(apenasNumeros[10].ToString()) == digY)
        {
            Console.WriteLine("CPF válido!");
        }
        else
        {
            Console.WriteLine("CPF inválido!");
            return;
        }
       
    }
}
