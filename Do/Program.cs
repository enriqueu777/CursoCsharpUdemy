internal class Program
{
	private static void Main(string[] args)
	{

		//do
		//{


		//}while (true);

		int numero = 0;

		do
		{
			Console.WriteLine(numero);

			if (numero == 12)
			{

				return;
			}

			numero++;

		}while (numero < 1200);
}
}
