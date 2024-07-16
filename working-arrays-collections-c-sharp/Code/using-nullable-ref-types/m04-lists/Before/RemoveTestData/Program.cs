using System;
using System.Collections.Generic;

namespace Pluralsight.ArraysCollections.Demos
{
	class Program
	{
		static void Main(string[] args)
		{
			BusRoute[] allRoutes = BusRouteRepository.InitializeRoutes();

			Console.WriteLine($"Before: There are {allRoutes.Length} routes:");
			foreach (BusRoute route in allRoutes)
				Console.WriteLine($"Route: {route}");

			// this isn't really a good way of removing an item - but it happens to work here
			Array.Resize(ref allRoutes, 4);

			Console.WriteLine($"\r\nAfter: There are {allRoutes.Length} routes:");
			foreach (BusRoute route in allRoutes)
				Console.WriteLine($"Route: {route}");
		}
	}
}
