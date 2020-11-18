using System;
using System.Collections.Generic;
using System.Text;

namespace TrainTrain.Domain
{
    public class BookingService
    {
        public BookingResult Book(Wagon wagon, int requestedBookingCount)
        {

            wagon.AddPassengers(requestedBookingCount);

            if (requestedBookingCount == 1)
            {
                return new BookingResult
                {
                    Success = true,
                    Amount = 50,
                };
            }
            else
            {
                return new BookingResult
                {
                    Success = true,
                    Amount = 200,
                };
            }
        }
    }
}
