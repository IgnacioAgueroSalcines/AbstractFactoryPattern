using Ninject.Modules;
using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern;

namespace AbstractFactoryPatternNoInject
{
    public class Configuracion : NinjectModule
    {
        private IVisitor visitante { get; set; }
        private Estrategia estrategia { get; set; }

        public Configuracion (IVisitor v, Estrategia e)
        {
            this.visitante = v;
            this.estrategia = e;
        }
        public override void Load()
        {
            Bind<IVisitor>().To(visitante.GetType());
            Bind<Estrategia>().To(estrategia.GetType());
        }
    }
}
