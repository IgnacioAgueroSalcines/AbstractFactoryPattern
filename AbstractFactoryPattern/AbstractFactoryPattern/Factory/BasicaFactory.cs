using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern;
using VisitorPattern;

namespace AbstractFactoryPattern.Factory
{
    public class BasicaFactory : AbstractFactory
    {      
        public BasicaFactory()
        {
            instance = null;
        }
        public override AbstractFactory getInstance()
        {
            if (instance == null)
            {
                instance = new BasicaFactory();
            }
            return instance;
        }

        public override void Load()
        {
            Bind<Estrategia>().To<InternacionalGallega>();
            Bind<IVisitor>().To<ImprimeArbolCompacto>();
        }
    }
}
