using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factory
{
    public abstract class EstrategiaAbstractFactory
    {
        public abstract Estrategia creaEstrategiaCatalana();

        public abstract Estrategia creaEstrategiaGallega();

        public abstract Estrategia creaEstrategiaIntCatalana();

        public abstract Estrategia creaEstrategiaIntGallega();
    }
}
