﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern;
using VisitorPattern;
using StrateyPatternConsole.Strategy;

namespace AbstractFactoryPattern.Factory
{
    public class ExtendidaGallegaFactory : AbstractFactory
    {
        protected ExtendidaGallegaFactory()
        {
        }

        public static AbstractFactory init()
        {
            return instance = new ExtendidaGallegaFactory();
        }

        public override Estrategia creaEstrategia()
        {
            Estrategia e = new InternacionalGallega();
            return e;
        }

        public override IVisitor creaVisitor()
        {
            IVisitor v = new ImprimeArbolExtendido();
            return v;
        }
    }
}
