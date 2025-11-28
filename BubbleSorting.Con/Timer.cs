using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting.Con
{
	public class Timer
	{

		#region Properties

		public Guid Id { get; set; } = Guid.NewGuid();

		public int Hour { get; set; } = DateTime.Now.Hour;

		public int Minute { get; set; } = DateTime.Now.Minute;

		public int Second { get; set; } = DateTime.Now.Second;

		public int Millisecond { get; set; } = DateTime.Now.Millisecond;

		public int Microsecond { get; set; } = DateTime.Now.Microsecond;

		public int Nanosecond { get; set; } = DateTime.Now.Nanosecond;

		#endregion

		#region Table Maker

		public static void DataTableCreator(List<Timer> dataSheet)
		{

			Console.WriteLine("┌──────┬────────┬────────┬───────┬──────┬──────┐");
			Console.WriteLine("│ Hour │ Minute │ Second │ mlSec │ μSec │ nSec │");
			Console.WriteLine("╞══════┼════════┼════════┼═══════┼══════┼══════╡");
			for (int i = 0; i < dataSheet.Count; i++)
			{
				Console.WriteLine($"│ {dataSheet[i].Hour.ToString("0000")} │  {dataSheet[i].Minute.ToString("0000")}  │  {dataSheet[i].Second.ToString("0000")}  │  {dataSheet[i].Millisecond.ToString("000")}  │ {dataSheet[i].Microsecond.ToString("0000")} │ {dataSheet[i].Nanosecond.ToString("0000")} │");
				if (i == dataSheet.Count - 1)
				{


					int nsecDiff = dataSheet[i].Nanosecond - dataSheet[i - 1].Nanosecond;
					int usecDiff = dataSheet[i].Microsecond - dataSheet[i - 1].Microsecond;
					int msDiff = dataSheet[i].Millisecond - dataSheet[i - 1].Millisecond;
					int sDiff = dataSheet[i].Second - dataSheet[i - 1].Second;
					int minDiff = dataSheet[i].Minute - dataSheet[i - 1].Minute;
					int hDiff = dataSheet[i].Hour - dataSheet[i - 1].Hour;
					if (nsecDiff < 0)
					{
						nsecDiff += 1000;
						usecDiff -= 1;
					}
					if (usecDiff < 0)
					{
						usecDiff += 1000;
						msDiff -= 1;
					}
					if (msDiff < 0)
					{
						msDiff += 1000;
						sDiff -= 1;
					}
					if (sDiff < 0)
					{
						sDiff += 60;
						minDiff -= 1;
					}
					if (minDiff < 0)
					{
						minDiff += 60;
						hDiff -= 1;
					}



					Console.WriteLine("╞══════╪════════╪════════╪═══════╪══════╪══════╡");
					Console.WriteLine($"│ {hDiff.ToString("0000")} │  {minDiff.ToString("0000")}  │  {sDiff.ToString("0000")}  │  {msDiff.ToString("000")}  │ {usecDiff.ToString("0000")} │ {nsecDiff.ToString("0000")} │");


					Console.WriteLine("└──────┴────────┴────────┴───────┴──────┴──────┘");
				}
				else
				{
					Console.WriteLine("├──────┼────────┼────────┼───────┼──────┼──────┤");
				}

			}

		}


		#endregion

	}
}
