using System.Globalization;
using System.Net.Http.Headers;
using System.Xml;

namespace BubbleSorting.Con
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Timer> timers = new List<Timer>();
			var data = new List<int>();
			Sorter sorter;


			#region RadixSort
			timers.Add(new Timer());
			data = DataCreator.UniqueRandomNumbers(100000);
			//DataCreator.Printer(data);
			sorter = new Sorter();
			//DataCreator.Printer(sorter.RadixSort(data));
			sorter.RadixSort(data);
			timers.Add(new Timer());
			Timer.DataTableCreator(timers);
			#endregion

			#region BubbleSort
			timers.Add(new Timer());
			data = DataCreator.UniqueRandomNumbers(100000);
			//DataCreator.Printer(data);
			sorter = new Sorter();
			//DataCreator.Printer(sorter.BubbleSort(data));
			sorter.BubbleSort(data);
			timers.Add(new Timer());
			Timer.DataTableCreator(timers);
			#endregion


			Console.ReadKey();
		}
	}
}

