using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting.Con
{
	public static class DataCreator
	{
		#region UnsortedNumberGenerator
		/// <summary>
		/// This MF is for generating 2,147,483,647 random numbers
		/// </summary>
		/// <returns>A 32bit integer List <see cref="List{Int32}"/> of random numbers</returns>
		public static List<int> UnsortedNumberGenerator()
		{

			Random _random = new Random();
			List<int> _theListOfSomeRandomGeneratedNumbers = new List<int>();
			for (int i = 0; i < Convert.ToInt32(int.MaxValue); i++)
			{
				_theListOfSomeRandomGeneratedNumbers.Add(Convert.ToInt32(_random.Next(0, Convert.ToInt32(int.MaxValue))));
			}

			return _theListOfSomeRandomGeneratedNumbers;

		}


		/// <summary>
		///
		/// </summary>
		/// <param name="count">
		/// <returns>A 32bit integer List <see cref="List{Int32}"/> of random numbers</returns>
		public static List<int> UnsortedNumberGenerator(this int count)
		{

			Random _random = new Random();
			List<int> _theListOfSomeRandomGeneratedNumbers = new List<int>();
			for (int i = 0; i < count; i++)
			{
				_theListOfSomeRandomGeneratedNumbers.Add(Convert.ToInt32(_random.Next(0, count + 1)));
			}

			return _theListOfSomeRandomGeneratedNumbers;

		}

		public static List<int> UniqueRandomNumbers(int count)
		{
			var rnd = new Random();
			var set = new HashSet<int>();

			while (set.Count < count)
				set.Add(rnd.Next(1, count + 1));

			return set.ToList();
		}

		#endregion

		#region Printer
		/// <summary>
		/// Very Simple Printer just enter the <see cref="List{T}" />
		/// </summary>
		/// <param name="ints"></param>
		public static void Printer(this List<int> ints) {
			ints.ForEach(i => { Console.Write($" {i} -"); });
			Console.WriteLine();
			Console.WriteLine("*************************************************************");
		}

		#endregion

	}
}
