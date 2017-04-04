using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundaClase
{
    class Kilometros
    {
       public int Cantidad;
        public Kilometros(int cantidad)
        {
            this.Cantidad = cantidad;
        }
        public static Kilometros operator + (Kilometros k1,Kilometros k2)
        {
            Kilometros kilometroaux = new Kilometros(0);
            kilometroaux.Cantidad = k1.Cantidad + k2.Cantidad;
            return kilometroaux;
        }
        //public static Kilometros operator +(Kilometros k1,int dato)
        //{
        //    Kilometros dato = new Kilometros(0);
        //    Kilometros kilometroaux = new Kilometros(0);
        //    kilometroaux.Cantidad = k1.Cantidad + dato;
        //    return kilometroaux;
        //}
        public static bool operator ==(Kilometros k1, Kilometros k2)
        {
            if(k1==k2)
            return true;
            return false;
        }
        public static bool operator !=(Kilometros k1, Kilometros k2)
        {
          
            return !(k1==k2);
        }
    }
}
