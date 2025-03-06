internal class Program
{
	private static void Main(string[] args)
	{


		int numero1 = 25;
		//Console.Write(numero1);
		//PasoPorValor(numero1);
		//Console.Write(numero1);



		int numero2 = 100;
		//Console.Write(numero2);
		//PasoPorReferecnia(ref numero2);
	 //   Console.Write(numero2);


		DevuelveDosValores(ref numero1, ref numero2);

		Console.WriteLine(numero1 + numero2);

	}


	//Este motodo pasa la copia del valor pero no la referencia y por eso no se modifica
	//public static void PasoPorValor(int numero1)
	//{

	//	numero1 = 55;

	//}


	////A	qui se modifica la referencia y por lo cual si que se modifica el valor.

	//public static void PasoPorReferecnia(ref int numero2)
	//{

	//	numero2 = 200;
	//}


	public static void DevuelveDosValores(ref int numero1, ref int numero2)
	{
		numero1 = 1000;
		numero2 = 2000;
	}

}

		