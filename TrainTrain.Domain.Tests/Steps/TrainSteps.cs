using FluentAssertions;
using TechTalk.SpecFlow;
using TrainTrain.Domain.Tests.Contexts;

namespace TrainTrain.Domain.Tests.Steps
{
    [Binding]
    public class TrainSteps
    {
        private readonly TrainContext _trainsContext;

        public TrainSteps(TrainContext trainsContext)
        {
            _trainsContext = trainsContext;
        }
        
        [Given(@"un wagon avec (.*) réservations?")]
        public void SoitUnWagonAvecReservations(int currentOccupancy)
        {
            var wagon = new Wagon();
            wagon.AddPassengers(currentOccupancy);
            _trainsContext.Wagons.Add(wagon);
        }
        
        [Then(@"le wagon est occupé à (.*)%")]
        public void AlorsLeWagonEstOccupeAPourcent(decimal occupancyRate)
        {
            _trainsContext.Wagons[0].OccupancyRate
                .Should().Be(occupancyRate);
        }
        
        [Then(@"le second wagon est occupé à (.*)%")]
        public void AlorsLeSecondWagonEstOccupeA(int occupancyRate)
        {
            _trainsContext.Wagons[1].OccupancyRate.Should().Be(occupancyRate);
        }
    }
}