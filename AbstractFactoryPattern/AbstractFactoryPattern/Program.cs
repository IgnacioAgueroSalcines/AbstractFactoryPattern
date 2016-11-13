using AbstractFactoryPattern.Factory;
using Composite;
using Ninject;
using StrategyPattern;
using StrateyPatternConsole.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos un inyector usando una cofiguración determinada
            IKernel injector = new StandardKernel(new BasicaFactory());

            IVisitor v = injector.Get<IVisitor>();

            //cambio de inyeccion
            injector = new StandardKernel(new AbiertaFactory());
            IVisitor v2 = injector.Get<IVisitor>();

            Directorio root = inicializa();

            Console.WriteLine("\nCompacto\n");
            v.ImprimeDirectorio(root);

            Console.WriteLine("\nExtendido\n");
            v2.ImprimeDirectorio(root);

            Console.Read();
        }

        public static Directorio inicializa()
        {
            //estrategia a utilizar
            Personalizada est = new Personalizada();
            est.reemplazo = "nn";

            Directorio root = new Directorio("Raíz", est);

            #region creacionObjetos
            //creacion de objetos

            Composite.Composite dir1 = new Directorio("Directorio Vacío ñ", est);
            Composite.Composite dir2 = new Directorio("Directorio con archivo único", est);
            Composite.Composite dir3 = new Directorio("Directorio con archivo comprimido simple", est);
            Composite.Composite dir4 = new Directorio("Directorio con directorio anidado", est);

            Archivo arc1 = new Archivo("foto001", 10, est);
            Archivo arc2 = new Archivo("foto002", 10, est);
            EnlaceDirecto enl1 = new EnlaceDirecto(arc1, est);
            Comprimido cmp1 = new Comprimido("ccSimple", est);
            Archivo arc4 = new Archivo("foto004", 10, est);
            EnlaceDirecto enl2 = new EnlaceDirecto(cmp1, est);
            EnlaceDirecto enl3 = new EnlaceDirecto(dir1, est);
            Composite.Composite dir5 = new Directorio("Directorio Con archivo comprimido complejo", est);

            Composite.Composite dir6 = new Directorio("Directorio Vacío en archivo comprimido", est);
            Archivo arc3 = new Archivo("foto003", 10, est);
            EnlaceDirecto enl4 = new EnlaceDirecto(arc1, est);
            Archivo arc5 = new Archivo("foto005", 10, est);
            Archivo arc6 = new Archivo("foto006", 10, est);
            Comprimido cmp2 = new Comprimido("ccComplejo", est);

            Comprimido cmp3 = new Comprimido("ccAnidada", est);
            Archivo arc8 = new Archivo("foto008", 10, est);

            Archivo arc7 = new Archivo("foto007", 10, est);

            #endregion

            #region linkObjetos
            //link de objetos
            cmp3.addComponente(arc7);

            cmp2.addComponente(cmp3);
            cmp2.addComponente(arc8);

            dir5.addComponente(arc5);
            dir5.addComponente(arc6);
            dir5.addComponente(cmp2);
            cmp1.addComponente(dir6);
            cmp1.addComponente(arc3);
            cmp1.addComponente(enl4);

            dir4.addComponente(arc4);
            dir4.addComponente(enl2);
            dir4.addComponente(enl3);
            dir4.addComponente(dir5);
            dir3.addComponente(arc2);
            dir3.addComponente(enl1);
            dir3.addComponente(cmp1);
            dir2.addComponente(arc1);

            root.addComponente(dir1);
            root.addComponente(dir2);
            root.addComponente(dir3);
            root.addComponente(dir4);

            #endregion

            return root;
        }
    }
}
