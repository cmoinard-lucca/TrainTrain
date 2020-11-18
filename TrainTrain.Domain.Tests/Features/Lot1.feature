Fonctionnalité: Lot1

Scénario: Wagon vide réservation 1 personne
	Etant donné un wagon avec 0 réservations
	Quand 1 réservation est demandée
	Alors la réservation est acceptée
	Et on a encaissé 50 euros
	Et le wagon est occupé à 1%

Scénario: Wagon rempli à 25 places, réservation pour 4 personnes
	Etant donné un wagon avec 25 réservations
	Quand 4 réservations sont demandées
	Alors la réservation est acceptée
	Et on a encaissé 200 euros
	Et le wagon est occupé à 29%

Scénario: Wagon rempli avec 70 places, réservation pour x personnes
	Etant donné un wagon avec 70 réservations
	Quand 1 réservation est demandée
	Alors la réservation est refusée
	Et on a encaissé 0 euros
	Et le wagon est occupé à 70%

Plan du scénario: Wagon non plein, réservation excédant le seuil de 70%
	Etant donné un wagon avec <occupation> réservations
	Quand <nbReservations> réservations sont demandées
	Alors la réservation est refusée
	Et on a encaissé 0 euros
	Et le wagon est occupé à <occupation>%

	Exemples:
		| occupation | nbReservations |
		| 65         | 10             |
		| 20         | 60             |
		| 69         | 2              |