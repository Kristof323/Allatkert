using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Madar : Allat
    {
        private int repulesiMagassag;

        public int RepulesiMagassag
        {
            get
            {
                return repulesiMagassag;
            }
            set
            {
                if (value < 5)
                {
                    repulesiMagassag = 5;
                }
                else if (value > 500)
                {
                    repulesiMagassag = 500;
                }
                else
                {
                    repulesiMagassag = value;
                }
            }
        }

        public Madar(
            string nev,
            int kor,
            int testsuly,
            int egeszseg,
            int repulesiMagassag
        ) : base(nev, kor, testsuly, egeszseg)
        {
            RepulesiMagassag = repulesiMagassag;
        }

        public override void InformaciotAd()
        {
            Console.WriteLine(
                $"{Nev} - {Kor} éves madár, {Testsuly} kg testsúllyal, " +
                $"maximális repülési magasság: {RepulesiMagassag} méter"
            );
        }

        public override void Gondoz(int ido)
        {
            RepulesiMagassag += 100;

            base.Gondoz(ido);
        }
    }
}
