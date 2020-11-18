using System;
using System.Collections.Generic;
using System.Text;

namespace TrainTrain.Domain.Tests.Contexts
{
    public class Lot1Context
    {
        public int BookingCount { get; set; }
        public BookingResult BookingResult { get; internal set; }
    }
}
