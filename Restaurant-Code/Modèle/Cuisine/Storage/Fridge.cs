﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class Fridge : Storage
    {
        public Fridge(List<Ingredients> listIngredients)
            :base(2, listIngredients)
        {

        }
    }
}
