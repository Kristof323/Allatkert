using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Ragadozo : Allat
    {
        private int taplalekMennyiseg;

        public int TaplalekMennyiseg
        {
            get
            {
                return taplalekMennyiseg;
            }
            set
            {
                if (value < 0)
                {
                    taplalekMennyiseg = 0;
                }
                else if (value > 10)
                {
                    taplalekMennyiseg = 10;
                }
                else
                {
                    taplalekMennyiseg = value;
                }
            }
        }

        public Ragadozo(
            string nev,
            int kor,
            int testsuly,
            int egeszseg,
            int taplalekMennyiseg
        ) : base(nev, kor, testsuly, egeszseg)
        {
            TaplalekMennyiseg = taplalekMennyiseg;
        }

        public override void InformaciotAd()
        {
            Console.WriteLine(
                $"{Nev} - {Kor} éves ragadozó, {Testsuly} kg testsúllyal, " +
                $"táplálék: {TaplalekMennyiseg} kg"
            );
        }

        public override void Gondoz(int ido)
        {
            TaplalekMennyiseg -= 5;

            base.Gondoz(ido);
        }
    }
}