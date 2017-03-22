using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Sello
    {
        public static string Mensaje;
        public static ConsoleColor Color;
        
        
        public static string Imprimir()
        {

            return "algo";
        }
        public void  BorrarMensaje()
        {
            Sello.Mensaje = "";
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.Color;
            Console.WriteLine(Sello.Mensaje);
 
        }
    }
}
