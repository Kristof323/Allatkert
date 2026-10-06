using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Allat
    {

        private string nev;
        public string Nev
        {
            get { if (nev == null || nev == "") return "NÉVTELEN"; else return nev; }
            set { nev = value; }
        }
        private int kor;
        public int Kor { 
            get { return kor; }
            set { if (value < 0) kor = 0; else if (value > 80) kor = 80; else kor = value; }
        }
        private int testsuly;
        public int Testsuly { 
            get { return testsuly; }
            set { if (value < 0) testsuly = 0; else testsuly = value; }
        }
        private int egeszseg;       
        public int Egeszseg {
            get { return egeszseg; }
            set { if (value < 0) egeszseg = 0; else if (value > 100) egeszseg = 100; else egeszseg = value; }
        }
        private bool gondozasSzukseges;
        public bool GondozasSzukseges { 
            get { return gondozasSzukseges; }
            set { gondozasSzukseges = value; }
        }

        public Allat(string nev, int kor, int testsuly, int egeszseg)
        {
            Nev = nev;
            Kor = kor;
            Testsuly = testsuly;
            Egeszseg = egeszseg;
            GondozasSzukseges = false;
        }

        public void InformaciotAd()
        {
            Console.WriteLine($"{Nev}-{Kor} éves állat,{Testsuly} kg súllyal.");
        }



        public void Gondoz(int ido)
        {
            if (ido > 30)
            {
                testsuly += 2;
                egeszseg += 15;
                if (egeszseg < 35)
                {
                    egeszseg = 50;
                }
                else
                {
                    egeszseg += 15;
                };
                Console.WriteLine("Az állat gondozása megtörtént.");








            }
        }

    }
}
