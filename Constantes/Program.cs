using System.Security.Cryptography.X509Certificates;

internal class Program
{


	public const string NOMBRE = "Pedro";

	public const int NUMERO_PEDIDOS_MAXIMO = 10;
	private static void Main(string[] args)
	{


		for (int i = 0; i < 12; i++)
		{

			if (i < NUMERO_PEDIDOS_MAXIMO)
			{

				Console.WriteLine(i);

			}
		}
	}
}