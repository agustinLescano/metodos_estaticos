using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundaClase
{
    class Rueda
    {
        private string Marca;
        private int Tamaño=0;
        public Rueda()
            { 

            //* constructores de instancia :tienen el mismo nombre que la clase
            //*pueden tener modificador de visibilidad(public,private,etc)
            //*no tienen valor de retorno
            //*pueden tener parametros
            //*se ejecutan al crear una instancia de la clase(objeto)
            //*se puede y debe utilizar el operador ""this"
            //*puede acceder a los atrivutos de instancia
            //*puede acceder a los atributos estaticos
            //*

            
                this.Marca = "sin marca";

                
            }
        public void MostrarRueda()
        {
            Console.WriteLine("la masca es " + this.Marca);
            Console.WriteLine("el tamaño es " + this.Tamaño);
        }
        public Rueda(string marca)
        {
            this.Marca = marca;
           
        }
        public Rueda(int tamaño):this()
        {
          
            this.Tamaño = tamaño;
        }
        public Rueda(int tamaño , string marca):this(tamaño)
        {
           
            this.Marca = marca;
        }
    }
}
