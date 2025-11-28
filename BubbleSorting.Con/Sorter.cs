using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting.Con
{
	public class Sorter
	{
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





		public List<string> RadixSort(List<string> listOfStrings)
		{

			// Coming soon


			//List<char> secondChars = new List<char>();
			//long carryNumber = 0;
			//int biggetNumberLength = int.MinValue;
			//for (int i = 0; i < listOfStrings.Count; i++)
			//{
			//	biggetNumberLength = listOfStrings[i].ToString().Length > biggetNumberLength ? listOfStrings[i].ToString().Length : biggetNumberLength;
			//}

			//for (int i = biggetNumberLength - 1; i >= 0; i--)
			//{

			//	listOfStrings = listOfStrings
			//		.OrderBy(s => i < s.Length ? s[i] : '0')
			//		.ToList(); 
			//}

			//return listOfStrings;
			return null;
		}
	}
}
