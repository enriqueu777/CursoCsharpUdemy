internal class Program
{
	private static void Main(string[] args)
	{
		bool bandera = true;

		//if (bandera)
		//{
		//	Console.WriteLine(" bandera es true");



		//}
		//else
		//{
		//	Console.WriteLine("bandera es false");
		//}

		int suma = 15 + 5;

		//suma.GetType().ToString();

		//if (suma <= 20)
		//{

		//	Console.WriteLine(suma);
		//}
		//else
		//{
		//	Console.WriteLine("Es mayor que 30");

		//}


		if (suma.GetType() == typeof(int))
		{

			Console.WriteLine(" Es de tipo Int");

		}

		//Seguiria la ejecucion aunque no pongamos un else.


		if (suma == 20 && bandera)
		{

			if (suma <= 30)
			{

				
			}

			if(bandera == true)
			{


			}


			}
		}

	}

	

