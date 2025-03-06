internal class Program
{
	private static void Main(string[] args)
	{
		Console.BackgroundColor = ConsoleColor.Magenta;

		Console.WriteLine("Hola ¿puedes indicarme tu nombre?");


		#region
		var nombre = Console.ReadLine();

		Console.WriteLine("¿puedes indicarme una ciudad");
		var localidad = Console.ReadLine();
		#endregion



		Console.WriteLine("Hola " + nombre + "  bienvenido  a   " + localidad);



		Console.ReadKey();



		Console.WriteLine(float.MinValue);
		Console.WriteLine(float.MaxValue);

		

		Console.WriteLine(nombre);






	}
}