using System.Collections.Generic;

namespace TrainTrain.Domain.Tests.Contexts
{
    public class TrainContext
    {
        public List<Wagon> Wagons { get; } = new List<Wagon>();
    }
}