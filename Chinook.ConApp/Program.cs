using System;

namespace Chinook.ConApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
			Console.WriteLine("x        Chinook-Marketing        x");
			Console.WriteLine("x        Kemal Yavuz              x");
			Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
			Console.WriteLine();

			var (avg, max, min) = Report.MarketingReports.GetTrackTimes();

			///Ausgabe längster Track, kürzester Track und durchschnittliche Spielzeit aller Tracks
			///max = längster Track
			///min = kürzester Track
			///avg = durchschnittliche Länge aller Tracks
			Console.WriteLine("Track-Zeit-Auswertung");
            Console.WriteLine("Track/Titel");
			Console.WriteLine("{0,-65} {1,25}", max.Name, max.Seconds);
			Console.WriteLine("{0,-65} {1,25}", min.Name, min.Seconds);
			Console.WriteLine("{0,-65} {1,25:f2}\n", "AVG-Time", avg / 1000);

            var (avgSecond, maxSecond, minSecond) = Report.MarketingReports.GetAlbumTime();

			///Ausgabe längstes Album, kürzestes Album und durchschnittliche spielzeit aller Alben
			///maxSecond = längstes Album
			///minSecond = kürzestes Album
			///avgSecond = durchnittliche Spielzeit aller Alben
			Console.WriteLine("Album-Zeit-Auswertung");
			Console.WriteLine("Album/Titel");
			Console.WriteLine("{0,-65} {1,25}", maxSecond.Name, maxSecond.Seconds);
			Console.WriteLine("{0,-65} {1,25}", minSecond.Name, minSecond.Seconds);
			Console.WriteLine("{0,-65} {1,25:f2}\n", "AVG-Time", avgSecond);

			var sales = Report.MarketingReports.GetTrackSales();

			///Ausgabe höchste Verkaufszahlen, niedrigste Verkaufszahlen, höchster Umsatz und niedrigster Umsatz
			///sales = alle Verkaufsinformationen
			Console.WriteLine("Track-Verkauf-Auswertung");
			Console.WriteLine("Track/Titel");
			Console.WriteLine("{0,-65} {1,25}", sales.HighestSales.Name, sales.HighestSales.Secondary);
			Console.WriteLine("{0,-65} {1,25}", sales.LowestSales.Name, sales.LowestSales.Secondary);
			Console.WriteLine("{0,-65} {1,25}", sales.HighestRevenue.Name, sales.HighestRevenue.Secondary);
			Console.WriteLine("{0,-65} {1,25}", sales.LowestRevenue.Name, sales.LowestRevenue.Secondary);

			var customers = Report.MarketingReports.GetCustomersInfo();

			///Ausgabe Kunde mit höchsten, niedrigsten Umsatz und der durchschnittliche Umsatz aller Kunden
			///customers = alle Kundeninformationen
			Console.WriteLine("Kunden-Auswertung");
			Console.WriteLine("Kunde/Name");
			Console.WriteLine("{0,-65} {1,25}", customers.TopCustomer.Name, customers.TopCustomer.Secondary);
			Console.WriteLine("{0,-65} {1,25}", customers.BottomCustomer.Name, customers.BottomCustomer.Secondary);
			Console.WriteLine("{0,-65} {1,25:f2}\n", "AVG-Time", customers.Average);

			var (genreMax, genreMin) = Report.MarketingReports.GetGenresInfo();

			///Ausgabe Genre mit höchster und niedrigster Verkaufszahl
			///genreMax = Genre mit der höchsten Verkaufszahl
			///genreMin = Genre mit der niedrigstern Verkaufszahl
			Console.WriteLine("Genre-Verkauf-Auswertung");
            Console.WriteLine("Genre/Name");
			Console.WriteLine("{0,-65} {1,25}", genreMax.Name, genreMax.Secondary);
			Console.WriteLine("{0,-65} {1,25}\n", genreMin.Name, genreMin.Secondary);

			Console.WriteLine("Press any key to continue ...");
			Console.ReadKey();
		}
	}
}
