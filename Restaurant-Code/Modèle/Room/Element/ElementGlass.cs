﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room.Element
{
    class ElementGlass : RoomStuff
    {
        public ElementGlass(string name, string type) : base(name, type)
        {
            this.name = "Glass";
            this.type = type;
        }
    }
}
