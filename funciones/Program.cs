internal class Program
{
	private static void Main(string[] args)
	{
		string saludo = Saludo("Enrique", "Utrero");


		Console.WriteLine(saludo);
	}

	// pasamos parametros y devuelve
	public static string Saludo(string nombre, string apellido)
	{


		return "Hola mi nombre es " + nombre +  " " + apellido;	
	}

	// pasamos parametros pero no devuelve nada
	public  static void DiNombre( string nombre, string apellido)
	{
		Console.WriteLine("Mi nombre es " +nombre +apellido);
	}
	// funncion sin parametros que devuelve valor.
	public static int Suma()
	{

		return 7 + 9;
	}
	// metodo que devuelve y con paso de parametros.
	public static int OperacionSuma(int numero1, int numero2){


		return numero1 + numero2;

		}

}