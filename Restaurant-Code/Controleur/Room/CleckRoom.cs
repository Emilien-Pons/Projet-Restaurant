﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Room
{
    class CleckRoom : Commun.Actor
    {
        public string name { get; set; }

        public CleckRoom(string name)
        {
            this.name = name;
        }
    }
}
