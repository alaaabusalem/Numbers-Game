namespace lab01_Numbers
{
	internal class Program
	{

		static void Main(string[] args)
		{
			try
			{
				StartSequence();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				Console.WriteLine("this is the end of our first asp.net programe");
			}
		}

		static void StartSequence()
		{
			try
			{
				Console.WriteLine(" welcome to my Game! Let's do some math Enter a number greater than zero");
				int num = Convert.ToInt32(Console.ReadLine());
				int[] array = new int[num];
				array = Populate(array);
				
					int sum = GetSum(array);
				
				

				Console.WriteLine($"Your array size is {array.Length}");
				Console.WriteLine($"the numbers in the array are :");
				ArrayPrint(array);
				Console.WriteLine($"the sum of the array is {sum}");
				int product = GetProduct(array, sum);
				int quotient = GetQuotient(product);
			}
			catch (FormatException ex)
			{
				Console.WriteLine(ex.ToString());
			}

			catch (OverflowException ex)
			{
				Console.WriteLine(ex.ToString());
			}
			catch (LessThan20Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private static void ArrayPrint(int[] array)
		{
			foreach (int item in array)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine();
		}

		private static int GetQuotient(int product)
		{
			try
			{
				Console.WriteLine($"Please Enter a number to divide your product by");
				int num = Convert.ToInt32(Console.ReadLine());
				int quotient = product / num;
				Console.WriteLine($"{product}/{num}={quotient}");
				return quotient;
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine(ex.ToString());
				return -1;
			}
		}

		private static int GetProduct(int[] array, int sum)
		{
			try
			{
				Console.WriteLine($"Please Enter a random number between 1 and {array.Length}");
				int random = Convert.ToInt32(Console.ReadLine());
				int product = sum * array[random - 1];
				Console.WriteLine($"{sum}*{array[random - 1]}={product}");
				return product;
			}

			catch (IndexOutOfRangeException ex)
			{
				Console.WriteLine(ex.ToString());
				return -1;
			}

		}

		private static int[] Populate(int[] array)
		{

			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine($"Please enter a number {i + 1} of {array.Length}");
				array[i] = Convert.ToInt32(Console.ReadLine());
			}
			return array;
		}



		private static int GetSum(int[] array)
		{
			int sum = 0;
			foreach (int item in array)
			{
				sum += item;
			}
			if (sum < 20){
				throw new Exception("sum is less than 20");
			}
			else { return sum; }
		}
	}
}
