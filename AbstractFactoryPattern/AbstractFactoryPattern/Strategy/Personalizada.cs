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
        public String reemplazo { get; set; }

        public Personalizada()
        {
            reemplazo = null;
        }

        public override String filtro(String s)
        {
            String res = s;
            if (reemplazo!=null)
            {
                res= s.Replace("ñ", reemplazo);
            }
            return res;
        }
    }
}
