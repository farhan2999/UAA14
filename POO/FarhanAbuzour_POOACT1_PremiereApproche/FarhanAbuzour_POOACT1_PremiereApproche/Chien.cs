using System;
using System.Collections.Generic;
using System.Text;

namespace FarhanAbuzour_POOACT1_PremiereApproche
{
    internal class Chien
    {
        private string _nom;
        private DateTime _age;
        private string _race;
        private string _carnetSante;
        private double _poids;
        private string _couleur;

        public Chien(string nom, DateTime age, string race, string carnetSante, double poids, string couleur)
        {
            _nom = nom;
            _age = age;
            _race = race;
            _carnetSante = carnetSante;
            _poids = poids;
            _couleur = couleur;
        }

        public string Infochien()
        {
            return "Nom : " + _nom + " | Date de naissance : " + _age.ToShortDateString() + " | Race : " + _race + " | Carnet de santé : " + _carnetSante + " | Poids : " + _poids + " kg | Couleur : " + _couleur;
        }

        public void Vacciner(string nomVaccin, DateTime dateVaccin)
        {
            _carnetSante = _carnetSante + " ; Vaccin " + nomVaccin + " le " + dateVaccin.ToShortDateString();
        }
    }
}