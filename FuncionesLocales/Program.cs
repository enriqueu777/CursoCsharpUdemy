internal class Program
{
	private static void Main(string[] args)
	{
		

		FuncionPrincipal(12);
	

		
	

	}

	public static void FuncionPrincipal(int numero)
	{

		Console.WriteLine(" Estamos dentro de la funcion principal " + numero);

		numero = numero + 10;

		FuncionLocal(numero);


		void FuncionLocal(int numeroLocal)
		{

			 numeroLocal = numeroLocal * 33;

			Console.WriteLine(numeroLocal);



		}



	}

}


