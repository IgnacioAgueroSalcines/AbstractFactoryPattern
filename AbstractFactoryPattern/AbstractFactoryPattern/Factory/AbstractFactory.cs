﻿using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern;

namespace AbstractFactoryPattern.Factory
{
    public abstract class AbstractFactory
    {
        protected static AbstractFactory instance;

        protected AbstractFactory() { }

        public abstract IVisitor creaVisitor();

        public abstract Estrategia creaEstrategia();

       

    }
}
