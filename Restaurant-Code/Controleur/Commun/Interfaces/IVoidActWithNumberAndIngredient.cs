﻿using Modèle.Cuisine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Commun.Interfaces
{
    interface IVoidActWithNumberAndIngredient
    {
        void act(int number, Ingredients ingredient);
    }
}
