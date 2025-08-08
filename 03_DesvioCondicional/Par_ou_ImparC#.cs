using System;

class ParOuImpar
{
	static void Main()
	{
		int numero, resultado;
		Console.WriteLine("Digite um numero: ");
		numero = int.Parse(Console.ReadLine() );
		
		resultado = numero % 2;
		if (resultado == 0)
		{
			Console.WriteLine("O número é Par");
		}
		else{
			Console.WriteLine("O número é Impar");
		}
	}
}