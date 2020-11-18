Fonctionnalité: Réserver des places
    
Scénario: Reservation d'une personne dans un wagon vide
    Etant donné un wagon vide 
    Quand je réserve 1 place
    Alors la réservation est acceptée
    Et le prix à payer est de 50€
    Et le remplissage est de 1%

Scénario: Reservation de 4 personnes dans un wagon avec 25 places prises
    Etant donné que le wagon a 25 places prises 
    Quand je réserve 4 places
    Alors la réservation est acceptée
    Et le prix à payer est de 200€
    Et le remplissage est de 29%

Scénario: Remplissage de 70% max
    Etant donné que le wagon a 70 places prises 
    Quand je réserve 1 place
    Alors la réservation est refusée
    Et le remplissage est de 70%

Plan du scénario: La reservation d'un groupe est refusée si elle fait dépasser les 70% de remplissage
    Etant donné que le wagon a <remplissage> places prises
    Quand je réserve <placesAReserver> places
    Alors la réservation est refusée
    Et le remplissage est de <remplissage>%
    
    Exemples:
        |placesAReserver|remplissage|
        |10             |65         |
        |50             |25         |
        |2              |69         |