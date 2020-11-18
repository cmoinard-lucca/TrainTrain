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