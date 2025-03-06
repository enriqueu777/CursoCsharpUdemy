using System;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
	private static void Main(string[] args)
	{
		//1 - Crear 3 variables numéricas con el valor que tu quieras
		//	y en otra variable
		//	numérica guardar el valor de la suma de las 3 anteriores.Mostrar por consola. 


		//int variable1 = 13;
		//int variable2 = 25;
		//int variable3 = 44;

		//int suma = variable1 + variable2 + variable3;

		//Console.WriteLine(suma);

		//2 - Pedir dos números al usuario por teclado y decir que número es el mayor.

		//Console.WriteLine("Introduce un primer numero");

		//int num1 = Int32.Parse(Console.ReadLine());

		//Console.WriteLine("Introduce un segundo numero");

		//int num2 = Int32.Parse(Console.ReadLine());

		//if (num1 > num2)
		//{

		//	Console.WriteLine("El primer es mayor");


		//}
		//else


		//{
		//	Console.WriteLine("El segundo es mayor");


		//}

		//3 - Pedir el nombre de la semana al usuario y decirle si es fin de semana o no. En caso de error, indicarlo




		//Console.WriteLine("Indique el numero de la semana");

		//string dia = Console.ReadLine();

		//if (dia == "Sabado" || dia == "Domingo")
		//{
		//	Console.WriteLine("Es fin de semana");
		//}
		//else
		//{
		//	Console.WriteLine("No es fin de semana");
		//}


		//4 - Pedir al usuario el precio de un producto(valor positivo) y la forma de pagar(efectivo o tarjeta)
		//	si la forma de pago es mediante tarjeta, pedir el numero de cuenta(inventado).


		//Console.WriteLine("Introduce el precio de un producto");

		//double precioProducto = Double.Parse(Console.ReadLine());

		//Console.WriteLine("Introduce la forma de pago");



		//string metodoPago = Console.ReadLine();		

		//if (metodoPago.ToLower()=="tarjeta")
		//{

		//	Console.WriteLine("Introduce el numero de cuenta");
		//	double numeroCuenta = Double.Parse(Console.ReadLine());

		//	Console.WriteLine("Operacion aceptada");
		//}
		//else
		//{
		//	Console.WriteLine("El pago es en efectivo");

		//}
		//5- Recorre los números del 1 al 100. Usa un bucle for.

		//int num = 0;

		//for (int i = 0; i <= 100; i++)
		//{

		////	Console.WriteLine(i);

		//////6- Recorre los números del 1 al 100. Usa un bucle while.
		////int num = 0;

		////while (num<=100) {
		////	Console.WriteLine(num);

		////	num++;

		//}

		//7- Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras.

		//int num = 0;

		//while (num <=100)
		//{
		//	if (num %2==0)
		//	{
		//		Console.WriteLine(num);
		//	}

		//	num++;



		//}


		//8- Recorre los números del 1 al 100. Muestra los números pares o divisibles entre 3.

		//int numero = 0;

		//while (numero <= 100)
		//{
		//	if (numero % 2 == 0)
		//	{
		//		Console.WriteLine(numero);
		//	}
		//	else if (numero % 3 == 0)
		//	{

		//		Console.WriteLine(numero);
		//	}


		//	numero++;
		//}

		//9 - Crea un array e inserta los números pares del 1 al 100 en ese array.

		//int indice = 0;

		//int[] numerosPares = new int[50];


		//for (int numero = 0; numero < 100; numero++)
		//{


		//	if (numero % 2 == 0)
		//	{
		//		numerosPares[indice] = numero;
		//		indice++;
		//	}

		//}


		//foreach(int numero in numerosPares)
		//{

		//	Console.WriteLine(numero);
		//}

		//10- Pide 10 números por consola, muestra el resultado por consola de sumar los pares y restarle los impares.


		//	int indice = 0;
		//	int numeroPar = 0;
		//	int numeroImpar = 0;


		//	int[] arrayNumeros = new int[10];


		//	do
		//	{
		//		Console.WriteLine("Introduce un numero");

		//		int numero = Int32.Parse(Console.ReadLine());

		//		arrayNumeros[indice] = numero;
		//		indice++;



		//	} while (indice < arrayNumeros.Length);


		//	foreach (int elemento in arrayNumeros)
		//	{
		//		if (elemento % 2 == 0)
		//		{
		//			numeroPar += elemento; // numero par + elemento


		//		}

		//		else
		//		{
		//			numeroImpar = -elemento; // numero impar - elemento
		//		}




		//	}
		//	int resultadoFinal = numeroPar - numeroImpar;

		//	Console.WriteLine($"Suma de los pares: {numeroPar}");
		//	Console.WriteLine($"Suma de los impares: {numeroImpar}");
		//	Console.WriteLine($"Resultado final: {resultadoFinal}");



		//11- Crea un programa, que pida un número del 1 al 7,  devuelva el día de la semana , teniendo en cuenta que el 1 es Lunes, hacer con un switch.


		//Console.WriteLine("Indique un numero de dia");

		//int dia = Int32.Parse(Console.ReadLine());

		//switch (dia)
		//{
		//	case 1:

		//		Console.WriteLine("Lunes");

		//		break;


		//	case 2:

		//		Console.WriteLine("Martes");

		//		break;
		//	case 3:

		//		Console.WriteLine("Miercoles");

		//		break;
		//	case 4:

		//		Console.WriteLine("Jueves");

		//		break;
		//	case 5:

		//		Console.WriteLine("Viernes");

		//		break;
		//	case 6:

		//		Console.WriteLine("Sabado");

		//		break;
		//	case 7:

		//		Console.WriteLine("Domingo");

		//		break;

		//	default:
		//		Console.WriteLine("La opcion elegida no es correcta");
		//		break ;

		//}



		//12 - Crea un programa que pida por consola un numero del 1 al 1000(validara que el numero introducido es correcto) 
		//y sume todos los números del 1 al numero introducido, mostrando por consola el numero de la suma y la media.


		//int sumaNumeros = 0;
		//int media = 0;
		//Console.WriteLine("Introduzca un numero de 1 a 1000");

		//int numero = Int32.Parse(Console.ReadLine());

		//if (numero >= 1 && numero <= 1000)
		//{
		//	Console.WriteLine("El numero es correcto");
		//}
		//else
		//{

		//	Console.WriteLine("El numero introducido es incorrecto");
		//}

		//int[] arrayNumeros = new int[numero];


		//for (int i = 0; i < arrayNumeros.Length; i++)
		//{

		//	arrayNumeros[i] = i + 1;
		//}



		//foreach (int elemento in arrayNumeros)
		//{



		//	sumaNumeros += elemento;





		//}

		//Console.WriteLine($"la suma de los elementos del array es {sumaNumeros}");

		//media = sumaNumeros / numero;

		//Console.WriteLine($"la media es  {media}");

		//13- Comprobar si un numero introducido por consola es primo
	}
}
















