using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundaClase
{
    class Program
    {
        static void Main(string[] args)
        {
            eFabricante fabricante;
            fabricante = eFabricante.ford;
          
            Auto  miAuto;
            Auto au2;
            Auto au3;
            Auto au4;
            au2 = new Auto();
            au3 = new Auto();
            au4 = new Auto();
            
            miAuto = new Auto();
            Auto.CantidadDeInstancias = 0;
           
           
          /*
          el fabricante cargado se forme de manera rabndon dentro
           * de las 3 maneras existentes 
           * 
           * creo un atibuto estaticode tipo randon 
           * inicializo el objeto el el constructor estatico
           * 
           */
                

        }
    }
}
