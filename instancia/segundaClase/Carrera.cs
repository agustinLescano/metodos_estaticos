using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundaClase
{
    class Carrera
    {
        public Auto aut1;
        public  Auto aut2;
        public Auto aut3;
        public Auto aut4;
        public Auto aut5;
        public Auto aut6;

        public Carrera()
        {
            aut1 = new Auto();
            aut2 = new Auto();
            aut3 = new Auto();
            aut4 = new Auto();
            aut5 = new Auto();
            aut6 = new Auto();


        }
        
       /// <summary>
        ///  se recibe un entero que representa la cantidad eçde interacciones que se realizaran
        //asignandole a cada auto una cantidad de minutos random. al terminar las interacciones 
        //mostrar que auto recorrio mas y gano la carrera
       /// </summary>
       /// <param name="minutos"></param>
        public void porTiempo(int minutos)
        {
            int contador;
            Random unRandom = new Random();
            for (contador = 0; contador < 100; contador++)
            {
                this.aut1.AgregarKilometros(unRandom.Next(0, 100));
                this.aut2.AgregarKilometros(unRandom.Next(0, 100));
                this.aut3.AgregarKilometros(unRandom.Next(0, 100));
                this.aut4.AgregarKilometros(unRandom.Next(0, 100));
                this.aut5.AgregarKilometros(unRandom.Next(0, 100));
                this.aut6.AgregarKilometros(unRandom.Next(0, 100));
            }
 
        }
    


    }
}
