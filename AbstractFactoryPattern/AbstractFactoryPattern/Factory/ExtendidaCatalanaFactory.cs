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

        public ExtendidaCatalanaFactory()
        {
            instance = null;
        }

        public override AbstractFactory getInstance()
        {
            if (instance == null)
            {
                instance = new ExtendidaCatalanaFactory();
            }
            return instance;
        }

        public override void Load()
        {
            Bind<Estrategia>().To<InternacionalCatalan>();
            Bind<IVisitor>().To<ImprimeArbolExtendido>();
        }
    }
}
