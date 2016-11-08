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
    }
}
