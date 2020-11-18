using System;

namespace TrainTrain.Domain
{
    public class Wagon
    {
        public int Capacity { get; } = 100;
        public int Occupancy { get; private set; } = 0;

        public void AddPassengers(int count)
        {
            if (Occupancy + count > Capacity)
            {
                throw new ArgumentException("Wagon capacity exceeded");
            }
            
            Occupancy += count;
        }

        public decimal OccupancyRate
            => (decimal)Occupancy / Capacity * 100;
    }
}
