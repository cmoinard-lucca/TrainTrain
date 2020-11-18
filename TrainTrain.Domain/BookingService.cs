namespace TrainTrain.Domain
{
    public class BookingService
    {
        public BookingResult Book(Wagon wagon, int requestedBookingCount)
        {
            if (!CanBook(wagon, requestedBookingCount))
            {
                return new BookingResult
                {
                    IsSuccess = false
                };
            }

            wagon.AddPassengers(requestedBookingCount);

            if (requestedBookingCount == 1)
            {
                return new BookingResult
                {
                    IsSuccess = true,
                    Amount = 50,
                };
            }
            else
            {
                return new BookingResult
                {
                    IsSuccess = true,
                    Amount = 200,
                };
            }
        }
        
        private bool CanBook(Wagon wagon, int requestBookingCount)
            => wagon.Occupancy + requestBookingCount <= 70;
    }
}
