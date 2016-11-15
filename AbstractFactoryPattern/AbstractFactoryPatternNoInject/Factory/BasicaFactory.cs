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
        protected BasicaFactory() { }
        public override void Load()
        {
            Bind<IVisitor>().To<ImprimeArbolCompacto>();
            Bind<Estrategia>().To<InternacionalGallega>();
        }
        

        public static AbstractFactory init()
        {
            return instance = new BasicaFactory();
        }
    }
}
