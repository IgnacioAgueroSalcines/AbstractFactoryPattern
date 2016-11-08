
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern;

namespace AbstractFactoryPattern.Factory
{
    public class EstrategiaFactory : EstrategiaAbstractFactory
    {
        public override Estrategia creaEstrategiaCatalana()
        {
            Estrategia estrategia = new Catalan();
            return estrategia;
        }

        public override Estrategia creaEstrategiaGallega()
        {
            Estrategia estrategia = new Gallego();
            return estrategia;
        }

        public override Estrategia creaEstrategiaIntCatalana()
        {
            Estrategia estrategia = new InternacionalCatalan();
            return estrategia;
        }

        public override Estrategia creaEstrategiaIntGallega()
        {
            Estrategia estrategia = new InternacionalGallega();
            return estrategia;
        }
    }
}
