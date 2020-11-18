using System;
using System.Collections.Generic;
using System.Text;

namespace TrainTrain.Domain
{
    public class BookingService
    {
        public BookingResult Book(int nombre)
        {
            return new BookingResult
            {
                Success = true,
                Amount = 50,
                OccupancyRate = 1
            };
        }
    }
}
