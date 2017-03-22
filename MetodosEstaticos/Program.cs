using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int elMayor;
            string dato;
            Console.WriteLine("HOLA MUNDO");
            elMayor=Comparadora.RetornarMayor(10,5);
          
            Sello.Mensaje = "nuevo mensaje";
            dato=Sello.Imprimir();
              Sello.Color = ConsoleColor.Yellow;
              Console.ReadLine();
            Sello.ImprimirEnColor();
           
            
            


        }
    }
}
