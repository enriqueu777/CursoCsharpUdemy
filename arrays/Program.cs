internal class Program
{
	private static void Main(string[] args)
	{


		//int[] array = { 1, 2, 3, 4, 5 };

		//for (int i = 0; i < array.Length; i++)
		//{

		//	Console.WriteLine(array[i]);


		//}

		//int[] array2 = new int[5];

		//array2[0] = 1;
		//array2[1] = 2;
		//array2[2] = 3;
		//array2[3] = 12;
		//array2[4] = 23;


		//for (int i = 0; i < array2.Length; i++)
		//{
		//	Console.WriteLine(array2[i]);
		//}


		//foreach (var elementos in array2)
		//{
		//	Console.WriteLine(elementos);

		//}

		//int[,] arrayBidimensional = { { 23, 55, 66, 55 }, { 87, 88, 66, 99 } };

		//for (int i = 0; i < arrayBidimensional.GetLongLength(0); i++)
		//{
		//	for (int j = 0; j < arrayBidimensional.GetLongLength(1); j++)
		//	{

		//		Console.WriteLine(arrayBidimensional[i, j]);
		//	}
		//}


		//foreach(var elementos in arrayBidimensional)
		//{

		//	Console.WriteLine(elementos);

		//}

		int[][] arrayEscalonado = new int[6][];

		arrayEscalonado[0] = new int[4] { 6, 6, 9, 1 };
		arrayEscalonado[1] = new int[2] { 6, 10 };

		for (int i = 0; i < arrayEscalonado.GetLongLength(0); i++)
		{

			for (int j = 0; j < arrayEscalonado.GetLongLength(1); j++)
			{

				Console.WriteLine(arrayEscalonado[i][j]);


			}


		}

	}

}