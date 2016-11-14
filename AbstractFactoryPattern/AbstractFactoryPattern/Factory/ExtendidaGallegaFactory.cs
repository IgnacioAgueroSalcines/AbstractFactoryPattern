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
        protected ExtendidaGallegaFactory()
        {
            instance = null;
        }

        public override AbstractFactory getInstance()
        {
            if (instance == null)
            {
                instance = new ExtendidaGallegaFactory();
            }
            return instance;
        }

        public override void Load()
        {
            Bind<Estrategia>().To<InternacionalGallega>();
            Bind<IVisitor>().To<ImprimeArbolExtendido>();
        }
    }
}
