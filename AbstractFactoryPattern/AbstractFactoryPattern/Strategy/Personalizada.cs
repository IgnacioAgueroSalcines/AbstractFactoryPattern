using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrateyPatternConsole.Strategy
{
   public class Personalizada:Estrategia
    {
        public String reemplazo;

        public Personalizada(String r)
        {
            reemplazo = r;
        }
        public override String filtro(String s)
        {
            return s.Replace(s,reemplazo);
        }
    }
}
