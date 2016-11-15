using StrategyPattern;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern;

namespace AbstractFactoryPattern.Factory
{
    public abstract class AbstractFactory:Ninject.Modules.NinjectModule
    {
        protected static AbstractFactory instance;

        protected AbstractFactory() { }

       

    }
}
