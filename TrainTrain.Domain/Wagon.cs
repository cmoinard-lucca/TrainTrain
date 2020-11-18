using System;
using System.Collections.Generic;
using System.Text;

namespace TrainTrain.Domain
{
    public class Wagon
    {
        public int Capacity { get; } = 100;
        public int Occupancy { get; private set; } = 0;

        public void AddPassengers(int count)
            => Occupancy += count;

        public decimal OccupancyRate
            => (decimal)Occupancy / Capacity * 100;

        public Wagon(
        {
        }
    }
}
