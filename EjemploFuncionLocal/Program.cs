internal class Program
{
	private static void Main(string[] args)
	{
		EjemploFuncionLocal();
	}


	public static void EjemploFuncionLocal()
	{
		int total = 0;
		List<int> lista = new List<int>();

		lista.Add(12);
		lista.Add(13);
		lista.Add(14);

		foreach (int numero in lista)
		{

			total = Suma(numero, total);

			Console.WriteLine(total);


		}

		static int Suma(int numero, int total)
		{

			int suma = numero + total;

			return suma;

		}
	}

}