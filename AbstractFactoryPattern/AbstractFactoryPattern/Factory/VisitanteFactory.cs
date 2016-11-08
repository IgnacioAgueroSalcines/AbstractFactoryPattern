using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern;

namespace AbstractFactoryPattern.Factory
{
    public class VisitanteFactory : VisitanteAbstractFactory
    {
        public override IVisitor compacto()
        {
            IVisitor visitante = new ImprimeArbolCompacto();
            return visitante;
        }

        public override IVisitor extendido()
        {
            IVisitor visitante = new ImprimeArbolExtendido();
            return visitante;
        }
    }
}
