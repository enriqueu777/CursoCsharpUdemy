internal class Program
{
	private static void Main(string[] args)
	{

		//int[] array = new int[3];

		//array[0] = 1;
		//array[1] = 2;
		//array[2] = 3;

		//foreach (int elemento in array)
		//{

		//	Console.WriteLine(elemento);
		//}

		//int[] arrayAsignacionDirecta = new int[] { 10, 6, 3, 6, 9, 3, 22 };

		//for (int i = 0; i < arrayAsignacionDirecta.Length; i++)
		//{


		//	Console.WriteLine(arrayAsignacionDirecta[i]);
		//}


		//int[][] arrayEcalonado = new int[3][];

		//arrayEcalonado[0] = new int[] { 23, 3, 4 };
		//arrayEcalonado[1] = new int[] { 23, 3, 488, 56, 98 };
		//arrayEcalonado[2] = new int[] { 23, 55, 88, 66 };

		//for (int i = 0; i < arrayEcalonado.Length; i++)
		//{
		//	{
		//		for (int j = 0; j < arrayEcalonado[i].Length; j++)
		//		{

		//			Console.WriteLine(arrayEcalonado[i][j]);


		//		}

		//	}

		//}

		//int[,] array2D = new int[3, 3] { { 2, 3, 10 }, { 2, 4, 10, }, { 6, 9, 10 } };

		//foreach (var elemento in array2D)
		//{
		//	Console.WriteLine(elemento);
		//}

		int[,] array2DAsisgnacionDirecta = new int[2,3];

		array2DAsisgnacionDirecta[0, 0] = 10;
		array2DAsisgnacionDirecta[0, 1] = 25;
		array2DAsisgnacionDirecta[0, 2] = 10;
		array2DAsisgnacionDirecta[1, 0] = 25;
		array2DAsisgnacionDirecta[1, 1] = 10;
		array2DAsisgnacionDirecta[1, 2] = 25;

		for(var i = 0; i < array2DAsisgnacionDirecta.GetLongLength(0); i++)
		{
			for(var j = 0;	j< array2DAsisgnacionDirecta.GetLongLength(1); j++)
			{

				Console.WriteLine( array2DAsisgnacionDirecta [i, j] );	

			}
		}
		




	}

}






