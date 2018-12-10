﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.dbModel
{
    class Member
    {
        // Member ID
        public int ID { get; set; }

        // Member name (ex: John, Mike, Joe, ...)
        public string name { get; set; }

        // Amount of a certain role in the restaurant
        public int roleID { get; set; }
    }
}
