using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Constructie
    {
        private double suprafata;
        private string strada;
        private int numar;
        private double euroPerMetruPatrat;

        public Constructie(double suprafata, string strada, int numar, double euroPerMetruPatrat)
        {
            this.suprafata = suprafata;
            this.strada = strada;
            this.numar = numar;
            this.euroPerMetruPatrat = euroPerMetruPatrat;
        }

        ~Constructie()
        {

        }

        public double resultatulCalculat()
        {
            return suprafata * euroPerMetruPatrat;
        }

        public virtual string tipCladire()
        {
            return "Constructie";
        }

        public override string ToString()
        {
            return "Strada: " + strada + "\n" +
                    "Numarul: " + numar + "\n" +
                    "Costul suprafetei: " + resultatulCalculat() + "\n" +
                    "Tipul cladirii: " + tipCladire() + "\n";
        }

    }
}
