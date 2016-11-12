using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern;
using VisitorPattern;
using StrateyPatternConsole.Strategy;

namespace AbstractFactoryPattern.Factory
{
    public class EstandarFactory : AbstractFactory
    {
        protected AbstractFactory instance;

        protected EstandarFactory()
        {
            instance = null;
        }

        public override Estrategia creaEstrategia()
        {
            Estrategia estrategia = new Castellano();
            return estrategia;
        }

        public override IVisitor creaVisitante()
        {
            IVisitor visitante = new ImprimeArbolExtendido();
            return visitante;
        }

        public override AbstractFactory getInstance()
        {
            if (instance == null)
            {
                instance = new EstandarFactory();
            }
            return instance;
        }
    }
}
