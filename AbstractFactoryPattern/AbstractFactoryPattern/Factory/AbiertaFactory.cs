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

        protected AbiertaFactory()
        {
            instance = null;
        }

        public override AbstractFactory clone()
        {
            return (AbstractFactory)this.MemberwiseClone();
        }

        public override Estrategia creaEstrategia()
        {
            Estrategia estrategia = new Personalizada();
            return estrategia;
        }

        public override IVisitor creaVisitante()
        {
            IVisitor visitante = new ImprimeArbolExtendido();
            return visitante;
        }

        public override AbstractFactory getInstance()
        {
            if (instance == null)
            {
                instance = new AbiertaFactory();
            }
            return instance;
        }
    }
}
