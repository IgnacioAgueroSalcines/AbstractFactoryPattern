using Ninject.Modules;
using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern;

namespace AbstractFactoryPattern.Factory
{
    public abstract class AbstractFactory:NinjectModule
    {
        public AbstractFactory instance;

        public abstract AbstractFactory getInstance() ;

    }
}
