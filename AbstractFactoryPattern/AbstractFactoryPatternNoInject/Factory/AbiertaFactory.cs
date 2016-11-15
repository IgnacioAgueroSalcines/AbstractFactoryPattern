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
    public class AbiertaFactory :  AbstractFactory
    {
        public static Estrategia  estrategia;

        protected AbiertaFactory()
        {
        }

        public static void setEstrategia(Estrategia e)
        {
            estrategia = e;
            
        }

        


        public static AbstractFactory init()
        {
            return instance = new AbiertaFactory();
        }

        public override void Load()
        {
            Type tipo = estrategia.GetType();
            Bind<IVisitor>().To<ImprimeArbolExtendido>();
            Bind<Estrategia>().To(tipo);
        }
    }
}
