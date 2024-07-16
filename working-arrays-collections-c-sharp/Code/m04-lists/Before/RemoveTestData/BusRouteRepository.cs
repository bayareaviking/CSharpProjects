using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.ArraysCollections.Demos
{
	class BusRouteRepository
	{
		public static List<BusRoute> InitializeRoutes()
		{
            List<BusRoute> result = new List<BusRoute> // Lists are always initialized empty, with elements added after
            {
                new BusRoute(40, new string[] { "Morecambe", "Lancaster", "Garstang", "Preston" }),
                new BusRoute(42, new string[] { "Lancaster", "Garstang", "Blackpool" }),
                new BusRoute(1_000, new string[] { "Test origin", "Test destination" }),
                new BusRoute(5, new string[] { "Overton", "Morecambe", "Carnforth" }),
                new BusRoute(555, new string[] { "Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick" })
            }; // Above code is a "simplified" version of the below Add() statements, similar to adding elements in an array inside the curly braces

            //result.Add(new BusRoute(40, new string[] { "Morecambe", "Lancaster", "Garstang", "Preston" }));
            //result.Add(new BusRoute(42, new string[] { "Lancaster", "Garstang", "Blackpool" }));
            //result.Add(new BusRoute(1_000, new string[] { "Test origin", "Test destination" }));
            //result.Add(new BusRoute(5, new string[] { "Overton", "Morecambe", "Carnforth" }));
            //result.Add(new BusRoute(555, new string[] { "Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick" }));
            return result;
		}
	}

}
