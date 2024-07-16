using System;
using System.Collections.Generic;

namespace Pluralsight.ArraysCollections.Demos
{
	class Program
	{
		static void Main(string[] args)
		{
			var allRoutes = BusRouteRepository.InitializeRoutes();

			foreach (BusRoute route in allRoutes.Values)
				Console.WriteLine(route);

			//Console.WriteLine("Which route do you want to look up?");
			//int number = int.Parse(Console.ReadLine());

			// using indexer. This will throw an exception if number doesn't exist
			// so you'll need to comment these lines out to test TryGetValue and ContainsKey 
			// with numbers that don't exist
			//BusRoute answer = allRoutes[number];
			//if (answer != null)
			//	Console.WriteLine($"The route you asked for is {answer}");
			//else
			//	Console.WriteLine($"There is no route with number {number}");

			// using TryGetValue()
			//bool success = allRoutes.TryGetValue(number, out BusRoute answer2);
			//if (success)
			//	Console.WriteLine($"The route you asked for is {answer2}");
			//else
			//	Console.WriteLine($"There is no route with number {number}");

			// using ContainsKey()
			//bool success2 = allRoutes.ContainsKey(number);
			//if (success2)
			//	Console.WriteLine($"The route you asked for is {allRoutes[number]}");
			//else
			//	Console.WriteLine($"There is no route with number {number}");
		}
	}
}
