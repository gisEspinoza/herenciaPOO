using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciaTeoria
{
    //clase hija o derivad
    //definimos la relacion de herencia entre Cat y Animal
    class Cat:Animal
    {
        //propiedades
        public int lives { get; set; }


        //metodos
        public string meow()
        {
            return "meoooowww";
        }

        //metodo sobreescrito
        public override string run()
        {
            //base.run();
            return "El gato esta corriendo.....";
        }
    }
}
