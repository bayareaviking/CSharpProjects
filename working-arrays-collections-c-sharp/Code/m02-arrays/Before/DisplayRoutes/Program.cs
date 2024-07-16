﻿using System;
using System.Collections.Generic;

namespace Pluralsight.ArraysCollections.Demos
{
	class Program
	{
		static void Main(string[] args)
		{
			BusRoute route40 = new BusRoute(40, "Morecambe", "Preston");
			BusRoute route42 = new BusRoute(42, "Lancaster", "Blackpool");

			BusRoute[] routes =
			{
				route40,
				route42,
				new BusRoute(100, "University", "Morecambe"),
				new BusRoute(555, "Lancaster", "Keswick")
			};
			BusRoute firstRoute = routes[0]; 
			BusRoute lastRoute1 = routes[routes.Length - 1];
            BusRoute lastRoute2 = routes[^1];

			Console.WriteLine($"Last Route 1 is: {lastRoute1}");
			Console.WriteLine($"Last Route 2 is: {lastRoute2}");
            foreach (BusRoute route in routes)
				Console.WriteLine(route);
		}
	}
}
