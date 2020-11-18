using TechTalk.SpecFlow;
using TrainTrain.Domain.Tests.Contexts;
using Xunit;

namespace TrainTrain.Domain.Tests.Steps
{
    [Binding]
    public class ReservationSteps
    {
        private readonly ReservationService _reservationService;
        private readonly ReservationContext _reservationContext;

        public ReservationSteps(ReservationContext scenarioContext)
        {
            _reservationService = new ReservationService();
            _reservationContext = scenarioContext;
        }
        [Given(@"un wagon vide")]
        public void SoitUnWagonVide()
        {
        }

        [When(@"je réserve (.*) place")]
        public void QuandJeReservePlace(int p0)
        {
            _reservationContext.ReservationAcceptee = _reservationService.Reserver();
        }

        [Then(@"la réservation est acceptée")]
        public void AlorsLaReservationEstAcceptee()
        {
            Assert.True(_reservationContext.ReservationAcceptee);
        }
    }
}
