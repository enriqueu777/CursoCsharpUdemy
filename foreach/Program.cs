internal class Program
{
	private static void Main(string[] args)
	{

		var listaDeNumeros = new List<int> { 1,2,3,4,5,6,7,8,9,10};

		foreach (int numero in listaDeNumeros)
		{

			Console.WriteLine(numero);	
		}

		var listaDePersonas = new List<Persona>();

		var persona1 = new Persona()
		{
			nombre = "Enrique",
			apellido ="Utrero",
			edad = 47

		};

		var persona2 = new Persona()
		{

			nombre = "Monica",
			apellido = "prieto",
			edad = 47
		};

		listaDePersonas.Add(persona1);
		listaDePersonas.Add (persona2);

		foreach (var persona in listaDePersonas)// itera sobre todas las personas que se han creado
		{
			Console.WriteLine(persona.nombre + " "+ persona.apellido + " tiene "  + persona.edad + " años");
		}

	}

	public class Persona
	{

		public string nombre { get; set; }
		public string apellido { get; set; }
		public int edad { get; set; }
	}


}

