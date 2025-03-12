internal class Program
{
	private static void Main(string[] args)
	{

		var opcion = PintaMenu(); //primero pinta elmenu

		while (opcion != "5")
		{
		
			EjecutaOpcion(opcion);
            opcion = PintaMenu();


        }
		

	}



	public static  String  PintaMenu()
	{

		Console.WriteLine("***Menu***");
		Console.WriteLine("***1. Suma ***");
		Console.WriteLine("***2. Resta ***");
		Console.WriteLine("***3. Multiplicacion ***");
		Console.WriteLine("***4. Mi operacion***");
		Console.WriteLine("***5. Salir  ***");
		return Console.ReadLine();
		
	}


	public static void  EjecutaOpcion(string opcion)
	{
		switch (opcion)
		{
			case "1":

				Console.WriteLine(Suma(10,22));
				break;

            case "2":

                Console.WriteLine(Resta (1, 22));
                break;

            case "3":

                Console.WriteLine(Multiplicacion(10, 22));
                break;

            case "4":

                Console.WriteLine(MiOperacion(10, 22));
                break;

        }

	}

	public static int Suma( int num1, int num2)
	{

		return num1 + num2;


	}

    public static  int Resta(int num1, int num2)
    {

        return num1 - num2;


    }

    public static int Multiplicacion(int num1, int num2)
    {

        return num1 * num2;


    }
    public static int MiOperacion(int num1, int num2)
    {
		var SumaNumero = Suma(num1, num2);

		var RestaNumero = Resta(num1, num2);

		return  SumaNumero * RestaNumero;


    }




}