using FluentAssertions;
using TechTalk.SpecFlow;
using TrainTrain.Domain.Tests.Contexts;

namespace TrainTrain.Domain.Tests.Steps
{
    [Binding]
    public class ReservationSteps
    {
        private readonly BookingService _bookingService;
        
        private readonly TrainContext _trainsContext;
        private readonly BookingContext _bookingContext;

        public ReservationSteps(TrainContext trainsContext, BookingContext bookingContext)
        {
            _trainsContext = trainsContext;
            _bookingContext = bookingContext;
            _bookingService = new BookingService();
        }


        [When(@"(.*) réservation est demandée")]
        [When(@"(.*) réservations sont demandées")]
        public void QuandReservationEstDemandee(int requestedBookingCount)
        {
            _bookingContext.BookingResult = _bookingService.Book(_trainsContext.Wagons, requestedBookingCount);
        }

        [Then(@"la réservation est acceptée")]
        public void AlorsLaReservationEstAcceptee()
        {
            _bookingContext.BookingResult.IsSuccess
                .Should().BeTrue();
        }
        
        [Then(@"la réservation est refusée")]
        public void AlorsLaReservationEstRefusee()
        {
            _bookingContext.BookingResult.IsSuccess
                .Should().BeFalse();
        }

        [Then(@"on a encaissé (.*) euros")]
        public void AlorsOnAEncaisseEuros(int amount)
        {
            _bookingContext.BookingResult.Amount
                .Should().Be(amount);
        }
    }
}
