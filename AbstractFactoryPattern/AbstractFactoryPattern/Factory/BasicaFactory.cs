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
        protected AbstractFactory instance;
       
        protected BasicaFactory()
        {
            instance = null;
        }

        public override Estrategia creaEstrategia()
        {
            Estrategia estrategia = new InternacionalGallega();
            return estrategia;
        }

        public override IVisitor creaVisitante()
        {
            IVisitor visitante = new ImprimeArbolCompacto();
            return visitante;
        }

        public override AbstractFactory getInstance()
        {
            if (instance == null)
            {
                instance = new BasicaFactory();
            }
            return instance;
        }
    }
}
