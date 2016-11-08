using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern;

namespace AbstractFactoryPattern.Factory
{
    public abstract class VisitanteAbstractFactory
    {
        public abstract IVisitor compacto();
        public abstract IVisitor extendido();

    }
}
