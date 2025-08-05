using System;

class CalculoIMC
{
	static void Main()
	{
		double peso, altura, imc;
		Console.WriteLine("Digite seu peso em Kg: ");
		peso = Double.Parse(Console.ReadLine() ); // equivale ao 'leia' do portugol
		//Double.Parse tira as aspas da resposta do usuario e coverte para o double
		Console.WriteLine("Digite sua altura em metros: ");
		altura = Double.Parse(Console.ReadLine() );
		
		imc = peso / (altura * altura);
		
		Console.WriteLine("Seu IMC é {0:F2}", imc);
		
		if(imc < 18.5)
		{
			Console.WriteLine("Abaixo do peso.");
		}else if(imc < 25)
		{
			Console.WriteLine("Peso ideal.");
		}else
		{
			Console.WriteLine("Acima do peso.");
		}
	}
}