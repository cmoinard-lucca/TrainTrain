namespace TrainTrain.Domain
{
    public class ReservationService
    {
        private readonly Wagon _wagon;

        public ReservationService(Wagon wagon)
        {
            _wagon = wagon;
        }

        public (bool accepte, int prixAPayer, int txRemplissage) Reserver(int placesAReserver)
        {
            var accepte = _wagon.NombreDePlacesPrises < 70;
            var prixAPayer = 50 * placesAReserver;
            var txRemplissage = _wagon.NombreDePlacesPrises + (accepte ? placesAReserver : 0);
            return (accepte, prixAPayer, txRemplissage);
        }
    }
}