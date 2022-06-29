﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class SacuvajPrijavuSO : OpstaSistemskaOperacija
    {
        public Prijava prijava;
        public bool Signal { get; set; } = true;
        public SacuvajPrijavuSO(Prijava prijava)
        {
            this.prijava = prijava;
        }

        public SacuvajPrijavuSO():base()
        {

        }

        public void Test()
        {
            Izvrsi();
        }

        protected override void Izvrsi()
        {
            try
            {
                repozitorijum.Sacuvaj(prijava);
            }
            catch (Exception ex)
            {
                Signal = false;
                throw;
            }
        }
    }
}
