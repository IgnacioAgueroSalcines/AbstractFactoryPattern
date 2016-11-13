using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern;
using VisitorPattern;
using StrateyPatternConsole.Strategy;
using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern.Factory
{
    public class AbiertaFactory :  AbstractAbierta
    {
        protected AbstractFactory instance;

        public AbiertaFactory()
        {
            instance = null;
        }

        public override AbstractFactory clone()
        {
            return (AbstractFactory)this.MemberwiseClone();
        }

        
        public override AbstractFactory getInstance()
        {
            if (instance == null)
            {
                instance = new AbiertaFactory();
            }
            return instance;
        }

        public override void Load()
        {
            Bind<Estrategia>().To<Personalizada>();
            Bind<IVisitor>().To<ImprimeArbolExtendido>();
        }
    }
}
