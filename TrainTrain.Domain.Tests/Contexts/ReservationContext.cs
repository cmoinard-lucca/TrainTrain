namespace TrainTrain.Domain.Tests.Contexts
{
    public class ReservationContext
    {
        public int PlacesLibres { get; set; }

        public bool ReservationAcceptee { get; set; }

        public int PrixAPayer { get; set; }

        public int TauxDeRemplissage { get; set; }
    }
}
