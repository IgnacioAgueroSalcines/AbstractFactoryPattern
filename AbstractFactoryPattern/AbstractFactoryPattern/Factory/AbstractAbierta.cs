using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern;
using VisitorPattern;

namespace AbstractFactoryPattern.Factory
{
    public abstract class AbstractAbierta : AbstractFactory
    {
        public abstract override Estrategia creaEstrategia();

        public abstract override IVisitor creaVisitante();

        public abstract override AbstractFactory getInstance();

        public abstract AbstractFactory clone();
    }
}
