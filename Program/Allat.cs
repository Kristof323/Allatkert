using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Allat
    {
        private string nev = "NÉVTELEN";
        private int kor;
        private int testsuly;
        private int egeszseg;

        public string Nev
        {
            get
            {
                return nev;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    nev = "NÉVTELEN";
                }
                else
                {
                    nev = value;
                }
            }
        }

        public int Kor
        {
            get
            {
                return kor;
            }
            set
            {
                if (value < 0)
                {
                    kor = 0;
                }
                else if (value > 80)
                {
                    kor = 80;
                }
                else
                {
                    kor = value;
                }
            }
        }

        public int Testsuly
        {
            get
            {
                return testsuly;
            }
            set
            {
                if (value < 0)
                {
                    testsuly = 0;
                }
                else
                {
                    testsuly = value;
                }
            }
        }

        public int Egeszseg
        {
            get
            {
                return egeszseg;
            }
            set
            {
                if (value < 0)
                {
                    egeszseg = 0;
                }
                else if (value > 100)
                {
                    egeszseg = 100;
                }
                else
                {
                    egeszseg = value;
                }
            }
        }

        public bool GondozasSzukseges
        {
            get
            {
                return Egeszseg <= 50;
            }
            set
            {
                if (egeszseg <= 50)
                {
                    value=true;
                }
            }
        }

        public Allat(string nev, int kor, int testsuly, int egeszseg)
        {
            Nev = nev;
            Kor = kor;
            Testsuly = testsuly;
            Egeszseg = egeszseg;
        }

        public virtual void InformaciotAd()
        {
            Console.WriteLine(
                $"{Nev} - {Kor} éves állat, {Testsuly} kg súllyal"
            );
        }

        public virtual void Gondoz(int ido)
        {
            if (ido > 30)
            {
                Testsuly += 2;
            }

            Egeszseg += 15;

            if (Egeszseg < 50)
            {
                Egeszseg = 50;
            }

            Console.WriteLine($"{Nev} gondozása megtörtént.");
        }
    }
}