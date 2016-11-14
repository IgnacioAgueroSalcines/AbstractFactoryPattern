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
        public EstandarFactory()
        {
            instance = null;
        }

        public override AbstractFactory getInstance()
        {
            if (instance == null)
            {
                instance = new EstandarFactory();
            }
            return instance;
        }

        public override void Load()
        {
            Bind<Estrategia>().To<Castellano>();
            Bind<IVisitor>().To<ImprimeArbolExtendido>();
        }
    }
}
