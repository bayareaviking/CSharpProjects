using System;
using System.Collections.Generic;

namespace Pluralsight.ArraysCollections.Demos
{
	class Program
	{
		static void Main(string[] args)
		{
			List<BusRoute> allRoutes = BusRouteRepository.InitializeRoutes();

			Console.WriteLine($"Before: There are {allRoutes.Count} routes:");
			//foreach (BusRoute route in allRoutes)
			//	Console.WriteLine($"Route: {route}");
			for (int i = 0; i < allRoutes.Count; i++)
			{
				Console.WriteLine($"Route: {allRoutes[i]}");
			}

			// this isn't really a good way of removing an item - but it happens to work here
			//Array.Resize(ref allRoutes, 4);

			//allRoutes.Remove(allRoutes[2]); // Simple remove if you know the index of the item you want
			//allRoutes.RemoveAt(2); // Same as above
			allRoutes.RemoveAll(route => route.Origin.StartsWith("Test"));

            Console.WriteLine($"\r\nAfter: There are {allRoutes.Count} routes:");
			foreach (BusRoute route in allRoutes)
				Console.WriteLine($"Route: {route}");
		}
	}
}
