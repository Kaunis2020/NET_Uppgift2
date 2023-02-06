using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Uppgift2.Models
{
    public class Bok
    {
        private string titel = string.Empty;
        private string author = string.Empty;
        private string kategori = string.Empty;
        private string descrip = string.Empty;
        private string utgyear = string.Empty;
        private string bild = string.Empty;
        private int ant_sidor = 0;
        private double pris = 0.0;

        public Bok(string ti, string forf, string kat, string bes, string yea, string im, int sidor, double pr)
        {
            titel = ti;
            author = forf;
            kategori = kat;
            descrip = bes;
            utgyear = yea;
            bild = im;
            ant_sidor = sidor;
            pris = pr; // Pris;
        }

        public string Titel
        {
            get { return titel; }
        }

        public string Author
        {
            get { return author; }
        }

        public string Kategori
        {
            get { return kategori; }
        }

        public string Beskrivning
        {
            get { return descrip; }
        }

        public string UtgivDatum
        {
            get { return utgyear; }
        }

        public string Bild
        {
            get { return bild; }
        }

        public int AntalSidor
        {
            get { return ant_sidor; }
        }

        public double Pris
        {
            get { return pris; }
        }
    }
}