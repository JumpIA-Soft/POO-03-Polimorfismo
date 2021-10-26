using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_animales
{
    class carnívoro : Animal
    {
        private string tipoCarne;

        public carnívoro(string tipoCarne, string nombreA, int edadA): base(nombreA, edadA)
        {
            this.tipoCarne = tipoCarne;
        }

        public string getTipoCarne()
        {
            return tipoCarne;
        }
        public void setTipoCarne(string tipoCarne)
        {
            this.tipoCarne = tipoCarne;
        }

        //proceso de polimorfismo
        public override string comerAnimal()//la Key Override permite 
        {
            Animal objA = new Animal("animal1", 3);
            //accediendo a clase padre y reescribiendo en la clase heredada
            return objA.comerAnimal() + " de tipo carnicos!";
        }
        public override string caminarAnimal()
        {
            return "Caminando en busca de carne!";
        }
    }
}
