using System.Globalization;
using System.Xml;

namespace BubbleSorting.Con
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Timer> timers = new List<Timer>();
			timers.Add(new Timer());


			var data = DataCreator.UniqueRandomNumbers(1000);
			//DataCreator.Printer(data);
			Sorter sorter = new Sorter();
			DataCreator.Printer(sorter.BubbleSort(data));

			timers.Add(new Timer());
			Timer.DataTableCreator(timers);

			Console.ReadKey();
		}
	}
}

