﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    internal class Dolgozok
    {
        public int dolgozokid;
        public string nev;
        public string neme;
        public string reszleg;
        public int belepesev;
        public int ber;

        public Dolgozok(int dolgozokid, string nev, string neme, string reszleg, int belepesev, int ber)
        {
            this.dolgozokid = dolgozokid;
            this.nev = nev;
            this.neme = neme;
            this.reszleg = reszleg;
            this.belepesev = belepesev;
            this.ber = ber;
        }
    }
}
