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
        public void SoitUnWagonAvecReservations(int p0)
        {
            _context.BookingCount = p0;
        }

        [When(@"(.*) réservation est demandée")]
        public void QuandReservationEstDemandee(int p0)
        {
            _context.BookingResult = _bookingService.Book(p0);
        }

        [Then(@"la réservation est acceptée")]
        public void AlorsLaReservationEstAcceptee()
        {
            _context.BookingResult.Success
                .Should().BeTrue();
        }

        [Then(@"on a encaissé (.*) euros")]
        public void AlorsOnAEncaisseEuros(int p0)
        {
            _context.BookingResult.Amount
                .Should().Be(p0);
        }

        [Then(@"le wagon est occupé à (.*) pourcent")]
        public void AlorsLeWagonEstOccupeAPourcent(int p0)
        {
            _context.BookingResult.OccupancyPercentage
                .Should().Be(p0);
        }
    }
}
