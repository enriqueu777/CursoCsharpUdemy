using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        

        var opcion = PintaMenu();
        EjecutaOpcion(opcion);

 
        
    }



    public static string PintaMenu()
    {

        Console.WriteLine("*** 1 Suma***");
        Console.WriteLine("*** 2 Resta***");
        Console.WriteLine("*** 3 Multiplicacion***");
        Console.WriteLine("*** 4 Division***");
        return Console.ReadLine();


    }



    public static void EjecutaOpcion(string opcion)
    {
        var numero1 = 0;
        var numero2 = 0;
        
        switch (opcion)
        {
            case "1":

                Console.WriteLine("Introduce un numero");
                numero1= Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduce otro numero");
                numero2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine(Suma(numero1, numero2));
                


                break;
            case "2":

                Console.WriteLine("Introduce un numero");
                numero1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduce otro numero");
                numero2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine(Resta(numero1, numero2));


                break;
            case "3":

                Console.WriteLine("Introduce un numero");
                numero1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduce otro numero");
                numero2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine(Multiplicacion(numero1, numero2));


                break;
            case "4":

                Console.WriteLine("Introduce un numero");
                numero1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduce otro numero");
                numero2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine(Division(numero1, numero2));


                break;
            default:

                Console.WriteLine("La opcion no es correcta");


                break;

        }
       

    }



    public static int  Suma( int num1, int num2)
    {



        return num1 + num2;
    }

    public static int Resta(int num1, int num2)
    {



        return num1 - num2;
    }


    public static int Multiplicacion(int num1, int num2)
    {



        return num1 * num2;
    }

    public static int Division(int num1, int num2)
    {



        return num1 / num2;
    }

}