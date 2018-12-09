﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class EnumKitchen
    {
        public enum IngredientsType { congelé, frais, sec };
        public enum KitchenToolsType { coupant,rond, plat, Dirt, OK};
        public enum DishState { preparing, OK, eaten}
        public enum DishType { entree, mainCourse, dessert }
    }
}
