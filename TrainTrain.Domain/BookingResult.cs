using System;
using System.Collections.Generic;
using System.Text;

namespace TrainTrain.Domain
{
    public class BookingResult
    {
        public bool Success { get; set; }
        public decimal Amount { get; set; }
        public int OccupancyPercentage { get; set; }
    }
}
