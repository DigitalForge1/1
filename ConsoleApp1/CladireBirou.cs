using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CladireBirou : Constructie
    {
        private string firma;
        private int numarDeAngajati;

        public CladireBirou(double suprafata, string strada, int numar, double euroPerMetruPatrat, string firma, int numarDeAngajati) :
            base(suprafata, strada, numar, euroPerMetruPatrat)
        {
            this.firma = firma;
            this.numarDeAngajati = numarDeAngajati;
        }

        ~CladireBirou()
        {

        }

        public override string tipCladire()
        {
            return "CladireBirou";
        }

        public override string ToString()
        {
            return base.ToString() + "Nume firma: " + firma + "\n" +
                "Numar de angajati: " + numarDeAngajati;
        }


    }
}
