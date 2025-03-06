internal class Program
{
	
	private static void Main(string[] args)
	{

		Console.WriteLine("Introduzca un numero");

		var numero = Int32.Parse(Console.ReadLine());



		//switch (numero)
		//{


		//	case 1:
		//		Console.WriteLine("Es un numero 1");

		//		break;
		//	case 2:
		//		Console.WriteLine("Es un numero 2");
		//		break;

		//	case 3:
		//		Console.WriteLine("Es un numero 3");
		//		break;

		//	default:
		//		Console.WriteLine("No existe la opcion");
		//		break;

		//}

		if (numero == 1)
		{

			Console.WriteLine("El numero es uno");

		}
		else
		{

			if (numero == 2)
			{
				Console.WriteLine("El numero es dos");
			}
			else
			{
				if (numero == 3)
				{
					Console.WriteLine("El numero es tres");

				}
				else
				{

					Console.WriteLine("No coincide con nada");
				}


			}


		}

	}

}