using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo_4_y_5
{
    class Capitulo_4_Ejercicio_1
    {
        //Declarando la variable
        int Number;
        String Value;

        public void Calcular() {

            Console.WriteLine("Elige un numero para mostrar la tabla del 1 al 10");

            //Pediendo la opcion
            Value = Console.ReadLine();
            Number = Convert.ToInt32(Value);
        
            //Mostrando por la Table
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Number + "X" + i + "=" + (i * Number));
            }
        }
    }
}
