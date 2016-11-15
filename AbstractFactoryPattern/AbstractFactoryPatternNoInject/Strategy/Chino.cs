using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Chino:Estrategia
    {
        public override String filtro(String s)
        {//r por l
            return s.Replace("r", "l");
        }
       
    }
}
