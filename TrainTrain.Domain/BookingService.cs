using System;
using System.Collections.Generic;
using System.Text;

namespace TrainTrain.Domain
{
    public class BookingService
    {
        public BookingResult Book(int nombre)
        {
            if (nombre == 1)
            {
                return new BookingResult
                {
                    Success = true,
                    Amount = 50,
                    OccupancyRate = 1
                };
            }
            else
            {
                return new BookingResult
                {
                    Success = true,
                    Amount = 200,
                    OccupancyRate = 29
                };
            }

        }
    }
}
