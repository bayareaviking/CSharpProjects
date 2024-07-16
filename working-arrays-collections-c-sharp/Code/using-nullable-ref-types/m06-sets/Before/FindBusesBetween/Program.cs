using System;
using System.Collections.Generic;

namespace Pluralsight.ArraysCollections.Demos
{
	class Program
	{
		static void Main(string[] args)
		{
			BusRouteRepository repository = new BusRouteRepository();

			Console.WriteLine("Where are you?");
			string startingAt = Console.ReadLine()!;

			Console.WriteLine("Where do you want to go to?");
			string goingTo = Console.ReadLine()!;

			BusRoute[] routes = repository.FindBusesBetween(startingAt, goingTo);

			if (routes.Length > 0)
				foreach (BusRoute route in routes)
					Console.WriteLine($"You can use route {route}");
			else
				Console.WriteLine($"No routes between {startingAt} and {goingTo}");
		}
		public static BusRoute[] FindBusesTo(BusRoute[] routes, string location)
		{
			return Array.FindAll(routes, route => route.Serves(location));
		}
	}
}
