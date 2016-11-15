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
        protected ExtendidaCatalanaFactory()
        {
        }

        public static AbstractFactory init()
        {
            return instance = new ExtendidaCatalanaFactory();
        }
        public override void Load()
        {
            Bind<IVisitor>().To<ImprimeArbolExtendido>();
            Bind<Estrategia>().To<InternacionalCatalan>();
        }
    }
}
