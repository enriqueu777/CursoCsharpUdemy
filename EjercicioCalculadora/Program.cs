using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        

        PintaMenu();


      


        
    }



    public static void PintaMenu()
    {

        Console.WriteLine("*** 1 Suma***");
        Console.WriteLine("*** 1 Resta***");
        Console.WriteLine("*** 1 Multiplicacion***");
        Console.WriteLine("*** 1 Resta***");
        Console.ReadLine();


    }



    public static void EjecutaOpcion(string opcion)
    {
        switch (opcion)
        {
            case "1":

                Console.WriteLine("Introduce dos  numeros");



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