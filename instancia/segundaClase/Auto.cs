using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundaClase
{
    class Auto
    {
        eFabricante fabricante;
       
        Rueda ruedaDD;
        Rueda ruedaDI;
        Rueda ruedaTD;
        Rueda ruedaTI;
        public static int CantidadDeInstancias;
        
        public Auto()
        {
            this.ruedaDD = new Rueda();
            this.ruedaDI=new Rueda();
            this.ruedaTD=new Rueda();
            this.ruedaTI=new Rueda();
            Auto.CantidadDeInstancias++;
            this.fabricante = eFabricante.honda;
            

        }
        //estaticos
        // no puede tener modificador de visivilidad
        // no se puede utilizar this

          static Auto()
        {
            Auto.CantidadDeInstancias = 0;
              
           


            
        }

    }
}
