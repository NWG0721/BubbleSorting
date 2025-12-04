using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting.Con
{
	public class Sorter
	{

		#region Bubble sort

		public List<int> BubbleSort(List<int> listOfNumbers)
		{
			int carryNumber = 0;
			for (int j = 0; j < (listOfNumbers.Count); j++)
			{
				for (int i = listOfNumbers.Count - 1; i > 0; i--)
				{
					if (listOfNumbers[i] < listOfNumbers[i - 1])
					{
						carryNumber = listOfNumbers[i - 1];
						listOfNumbers[i - 1] = listOfNumbers[i];
						listOfNumbers[i] = carryNumber;
					}
				}
				#region Logger

				//Console.Write($"{j} ===> ");
				//listOfNumbers.ForEach(lON => Console.Write($"{lON} - "));
				//Console.WriteLine();

				#endregion
			}

			return listOfNumbers;
		}

		#endregion

		#region Radix sort system

		public List<string> RadixSort(List<string> listOfStrings)
		{

			int listCount = listOfStrings.Count;
			var maxLength = listOfStrings.Max(s => s.Length);

			for (int j = 0; j < listCount; j++)
			{
				for (int i = 0; i < maxLength; i++)
				{
					listOfStrings.OrderBy(s => i < s.Length ? s[i] : '0');
				}
			}

			//return listOfStrings;
			return listOfStrings;
		}
		public List<int> RadixSort(List<int> listOfNumbers)
		{
			int maxLength = listOfNumbers.Max();
			int exp = 1;
			while ((maxLength / exp) > 0)
			{
				listOfNumbers = listOfNumbers.OrderBy(n => (n / exp) % 10).ToList();
				exp *= 10;
			}
			return listOfNumbers;
		}

		#endregion


	}
}
