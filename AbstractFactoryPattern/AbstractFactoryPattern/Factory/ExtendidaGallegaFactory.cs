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
    public class ExtendidaGallegaFactory : AbstractFactory
    {
        protected ExtendidaGallegaFactory instance;

        protected ExtendidaGallegaFactory()
        {
            instance = null;
        }

        public override Estrategia creaEstrategia()
        {
            Estrategia estrategia = new InternacionalGallega();
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
                instance = new ExtendidaGallegaFactory();
            }
            return instance;
        }
    }
}
