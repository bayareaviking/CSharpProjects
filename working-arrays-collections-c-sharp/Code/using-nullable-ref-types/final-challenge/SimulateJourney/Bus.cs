using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.ArraysCollections.Demos
{
    public class Bus
    {
        public const int Capacity = 5;
        public int Space { get => Capacity - _passengers.Count; }

        private List<Passenger> _passengers = new List<Passenger>();
        public bool Load(Passenger passenger)
        {
            if (Space < 1)
                return false;

            _passengers.Add(passenger);
            Console.WriteLine($"{passenger} got on the bus");
            return true;
        }
        public void ArriveAt(string place)
        {
            Console.WriteLine($"\r\nBus arriving at {place}");
            if (_passengers.Count == 0)
                return;

            // need to remove passengers who want to get off here from the list
            // complicated by that you need to display them too
            // I would go for this solution:            
            List<Passenger> passengersToRemove = _passengers.FindAll(x => x.Destination == place);
            _passengers.RemoveAll(x => x.Destination == place);

            foreach (Passenger passenger in passengersToRemove)
                Console.WriteLine($"{passenger} is getting off");

            Console.WriteLine($"{_passengers.Count} people left on the bus");
        }
    }
}
