﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab1.Abstract_factory
{
    public abstract class AbstractFactoryBusinessLunch
    {
        public abstract AbstractFirstMeal CreateFirstMeal();
        public abstract AbstractSecondMeal CreateSecondMeal();

    }
}
