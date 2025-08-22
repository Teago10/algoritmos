using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08_ValidaCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cpf, apenasNumeros;
            // Calcula os dígitos verificadores
            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            Console.WriteLine("Informe seu CPF: ");
            cpf = Console.ReadLine();

            //Remove caracteres não numéricos
            apenasNumeros = Regex.Replace(cpf, @"\D", "");

            char[] vetorchar = apenasNumeros.ToCharArray();
            //Verifica se tem exatamente 11 dígitos
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
                Console.WriteLine("CPF Inválido");
                return;
            }

            // Pega os 9 primeiros dígitos do CPF para calcular o 1º dígito
            string tempCpf = apenasNumeros.Substring(0, 9);
            int soma = 0;

            // Calcula a soma do produto dos 9 primeiros dígitos pelos multiplicadores
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            }

            // Calcula o primeiro dígito verificador usando a regra do CPF
            // Se resto < 2 → dígito = 0, senão → dígito = 11 - resto
            int resto = soma % 11;
            int digito1 = (resto < 2) ? 0 : 11 - resto;

            // Adiciona o 1º dígito ao CPF temporário
            tempCpf += digito1;
            soma = 0; // Zera a soma para calcular o 2º dígito

            // Calcula a soma do produto dos 10 dígitos (9 originais + 1º dígito) pelos multiplicadores
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            }

            // Calcula o segundo dígito verificador
            resto = soma % 11;
            int digito2 = (resto < 2) ? 0 : 11 - resto;

            // Verifica se os dígitos calculados conferem com os dígitos do CPF informado
            if (cpf.EndsWith(digito1.ToString() + digito2.ToString()))
            {
                Console.WriteLine("CPF válido!");
                
            }

            foreach (char c in vetorchar)
            {
                Console.WriteLine(c);
            }

        }
    }
}
