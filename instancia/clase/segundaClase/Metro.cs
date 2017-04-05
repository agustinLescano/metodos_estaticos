using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundaClase
{
    class Metro
    {
        public int cantidad;
       
        
        
        private Metro(int Cantidad)
        {
            this.cantidad = Cantidad;
           
        }
        public static implicit operator Metro(Kilometros valor)
        {
            return new Metro(valor * 100);
        }
        public static Metro operator +(Metro unMetro, Kilometros k2)
        {
            Metro metroAux = new Metro(0);
           metroAux.cantidad = unMetro.cantidad + k2.Cantidad;
           return metroAux;
            
        }


    }
}
