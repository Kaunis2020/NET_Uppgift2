using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Uppgift2.Models
{
    public static class BokManager
    {
        private static List<Bok> boklista = new List<Bok>();

        /// <summary>
        ///  STATISK konstruktor;
        /// </summary>
        static BokManager()
        {
            boklista.Add(new Bok("Amfibie?! JAG?", "Nelson Nedem", "Djur och djurlivet",
                "Om livet i kärret bland grodor och paddor.", "2018", "amfibie.jpg", 36, 290));
            boklista.Add(new Bok("Krokodiler och andra urdjur", "Lise Lyngeland", "Djur och djurlivet",
                "Om riktigt gamla djur i vår natur som många gånger är snällare än man kan tro. Här får man också veta ett och annat om arternas ursprung.",
                "2016", "krokodil.jpg", 48, 284));
            boklista.Add(new Bok("Titta det växer!", "Erik Simon", "Natur", "Vardagen bland växter och djur hemma i trädgården.",
                "2017", "titta.jpg", 24, 120));
            boklista.Add(new Bok("Ödlans flykt", "Doriano Oregano", "Djur och djurlivet",
                "En bok som berättar om den kvicka lilla ödlan som gömmer sig i mörka skrevor.",
                "2018", "odlan.jpg", 36, 220));
        }

        public static Bok GetBok(int index)
        {
            return boklista.ElementAt(index);
        }
    }
}
