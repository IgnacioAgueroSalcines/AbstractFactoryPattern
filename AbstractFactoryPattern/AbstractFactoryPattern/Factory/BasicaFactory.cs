﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern;
using VisitorPattern;

namespace AbstractFactoryPattern.Factory
{
    public class BasicaFactory : AbstractFactory
    {
        protected BasicaFactory() { }
        public override Estrategia creaEstrategia()
        {
            Estrategia e = new InternacionalGallega();
            return e;
        }

        public override IVisitor creaVisitor()
        {
            IVisitor v = new ImprimeArbolCompacto();
            return v;
        }

        public static AbstractFactory init()
        {
            return instance = new BasicaFactory();
        }
    }
}
