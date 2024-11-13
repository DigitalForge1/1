using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Casa : Constructie
    {
        private int numarDeLocatari;
        private int numarCamere;

        public Casa(double suprafata, string strada, int numar, double euroPerMetruPatrat, int numarDeLocatari, int numarCamere) :
            base(suprafata, strada, numar, euroPerMetruPatrat)
        {
            this.numarDeLocatari = numarDeLocatari;
            this.numarCamere = numarCamere;
        }

        ~Casa()
        {

        }

        public override string tipCladire()
        {
            return "Casa";
        }

        public override string ToString()
        {
            return base.ToString() + "Numar de locatari: " + numarDeLocatari + "\n" +
                "Numar de camere: " + numarCamere;
        }

    }
}
