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
        protected EstandarFactory()
        {
        }

        public static AbstractFactory init()
        {
            return instance = new EstandarFactory();
        }

        public override void Load()
        {
            Bind<IVisitor>().To<ImprimeArbolExtendido>();
            Bind<Estrategia>().To<Castellano>();
        }
    }
}
