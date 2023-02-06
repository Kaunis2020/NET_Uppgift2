using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Uppgift2.Models
{
    public class KontaktForm
    {
        private string fornamn = string.Empty;
        private string eftnamn = string.Empty;
        private string epost = string.Empty;
        private string land = string.Empty;
        private string meddel = string.Empty;
        private static int nummer = 0;
        private readonly string id_num = string.Empty;
        private const string idstr = "ID000";
        private DateTime datum = DateTime.Now;

        public KontaktForm()
        {
            nummer++;
            id_num = "ID000" + nummer.ToString();
        }

        public string AnkomstDatum
        {
            get { return datum.ToShortDateString(); }
        }

        public string ForNamn
        {
            set { fornamn = value; }
            get { return fornamn; }
        }

        public string EftNamn
        {
            set { eftnamn = value; }
            get { return eftnamn; }
        }

        public string EPost
        {
            set { epost = value; }
            get { return epost; }
        }

        public string Land
        {
            set { land = value; }
            get { return land; }
        }

        public string Meddelande
        {
            set { meddel = value; }
            get { return meddel; }
        }

        public string ID_NUM
        {
            get { return id_num; }
        }
    }
}