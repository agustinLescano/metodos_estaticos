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
            Rueda Mirueda = new Rueda();
            Rueda Mirueda2 = new Rueda("buenisima");
            Rueda Mirueda3 = new Rueda(22);
            
            miAuto = new Auto();
            Auto.CantidadDeInstancias = 0;
            Kilometros kilometro1;
            Kilometros kilometro2;
            Kilometros aux;
           aux = new Kilometros(5);
            kilometro1 = new Kilometros(10);
           kilometro2 = new Kilometros(5);
           aux = kilometro1 + kilometro2;
          // int dato = kilometro1 + 33;

           
           
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
