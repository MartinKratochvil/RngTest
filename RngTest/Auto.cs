using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RngTest
{
    public class Auto
    {

        private string znacka;

        private int ujetoCelkem;

        private DateTime rozjezdTime;

        private TimeSpan dobaJizdyCelkem;

        public bool Jede { get; private set; }


        public Auto(string znacka) {
            this.znacka = znacka;
            ujetoCelkem = 0;
            dobaJizdyCelkem = TimeSpan.FromSeconds(0);
            Jede = false;
        }


        public void Rozjed()
        {
            rozjezdTime = DateTime.Now;
            Jede = true;
        }


        public void Zastav(int ujeto)
        {
            ujetoCelkem += ujeto;
            dobaJizdyCelkem += DateTime.Now - rozjezdTime;
            Jede = false;
        }


        public override string ToString()
        {
            return string.Format("značka: " + znacka + "\nUjeto Celkem: " + ujetoCelkem + "km\n Doba jízdy: " + dobaJizdyCelkem.Seconds + "s\nJede:" + (Jede ? "ano" : "ne"));
        }
    }
}
