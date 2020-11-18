using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TrainTrain.Domain.Tests.Contexts;
using Xunit;

namespace TrainTrain.Domain.Tests.Steps
{
    [Binding]
    public class StepDefinitions
    {
        private readonly BookingService _bookingService;
        private readonly Lot1Context _context;

        public StepDefinitions(Lot1Context context)
        {
            _context = context;
            _bookingService = new BookingService();
        }

        [Given(@"un wagon avec (.*) réservations")]
        public void SoitUnWagonAvecReservations(int bookingCount)
        {
            _context.BookingCount = bookingCount;
        }

        [When(@"(.*) réservation est demandée")]
        [When(@"(.*) réservations sont demandées")]
        public void QuandReservationEstDemandee(int bookingCount)
        {
            _context.BookingResult = _bookingService.Book(bookingCount);
        }

        [Then(@"la réservation est acceptée")]
        public void AlorsLaReservationEstAcceptee()
        {
            _context.BookingResult.Success
                .Should().BeTrue();
        }

        [Then(@"on a encaissé (.*) euros")]
        public void AlorsOnAEncaisseEuros(int amount)
        {
            _context.BookingResult.Amount
                .Should().Be(amount);
        }

        [Then(@"le wagon est occupé à (.*)%")]
        public void AlorsLeWagonEstOccupeAPourcent(int occupancyRate)
        {
            _context.BookingResult.OccupancyRate
                .Should().Be(occupancyRate);
        }
    }
}
