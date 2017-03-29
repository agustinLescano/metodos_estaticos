using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundaClase
{
    class Auto
    {
       private eFabricante fabricante;
       
        Rueda ruedaDD;
        Rueda ruedaDI;
        Rueda ruedaTD;
        Rueda ruedaTI;
        public static int CantidadDeInstancias;
        private int KilometrosRecorridos;
        //blic void volcelCero;
        #region
        //cuando tenenmos algo privado tengo formas de acceder aa ese metodo privado , puedo acceder esde el consatructor 
        // puedo hacer un metodo publico qe guarde los datos
        //metodos para que me lo muestre
        // son accecibbles para su escritura(asignarles un valor) a travezz de los contructores publicos y los metodos publicos
        //pueden serr accedidos`para escritura(debolver valor de datos a travez de metodos publicos).
        //en este lenguaje tambien se los puede acceder para lectura y escritura a travez de las propiedades
        #endregion

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
          public void AgregarKilometros(int kilometros)
          {
              this.KilometrosRecorridos = this.KilometrosRecorridos+kilometros;
          }
          public void volverCero()
          {
              this.KilometrosRecorridos = 0;
          }

         public int getKMS()
          {
             
               return  this.KilometrosRecorridos;
          }
        public void MostrarAuto()
        {
            Console.WriteLine("el fabricante es"+this.fabricante);
            Console.WriteLine("los kilometros recorridos son"+this.KilometrosRecorridos);
            this.ruedaDD.MostrarRueda();
            this.ruedaDI.MostrarRueda();
            this.ruedaTD.MostrarRueda();
            this.ruedaTI.MostrarRueda();

        }
            
        
        
       
          

    }
}
