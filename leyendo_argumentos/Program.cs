using static System.Console;


internal class Program
{
	private static void Main(string[] args)
	{
		WriteLine("Hay " + args.Length + " argumentos");


		foreach (string argumentos in args) 
		{

			Console.WriteLine(argumentos);
		}


	}

}