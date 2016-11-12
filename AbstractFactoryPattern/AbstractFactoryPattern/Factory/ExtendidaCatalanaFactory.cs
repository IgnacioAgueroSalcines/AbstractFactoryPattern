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
    public class ExtendidaCatalanaFactory : AbstractFactory
    {
        protected AbstractFactory instance;

        protected ExtendidaCatalanaFactory()
        {
            instance = null;
        }

        public override Estrategia creaEstrategia()
        {
            Estrategia estrategia = new InternacionalCatalan();
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
                instance = new ExtendidaCatalanaFactory();
            }
            return instance;
        }
    }
}
