namespace TrainTrain.Domain
{
    public class ReservationService
    {
        public (bool accepte, int prixAPayer, int txRemplissage) Reserver(int placesAReserver)
        {
            bool accepte = true;
            int prixAPayer = 50 * placesAReserver;
            int txRemplissage = placesAReserver == 1 ? 1 : 29;

            return (accepte, prixAPayer, txRemplissage);
        }
    }
}
