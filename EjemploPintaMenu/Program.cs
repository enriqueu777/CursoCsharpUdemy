internal class Program
{
	private static void Main(string[] args)
	{

		var opcion = PintaMenu();

	}



	public static String  PintaMenu()
	{

		Console.WriteLine("***Menu***");
		Console.WriteLine("***1. Suma ***");
		Console.WriteLine("***2. Resta ***");
		Console.WriteLine("***3. Multiplicacion ***");
		Console.WriteLine("***4. Mi operacion***");
		Console.WriteLine("***5. Salir  ***");
		return Console.ReadLine();
		
	}
}