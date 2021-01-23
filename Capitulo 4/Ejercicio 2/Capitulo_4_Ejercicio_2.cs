using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo_4_y_5
{
    class Capitulo_4_Ejercicio_2
    {
        //Declarando la variable
        int Number;
        int Raise;
        int Result;

        public void Elevator()
        {
           
            Console.WriteLine("Introduce un numero entero ");

            //Pediendo el numero
            Number = Convert.ToInt32(Console.ReadLine());

            //Pediendo el numero a Elevar
            Console.WriteLine("para elevarlo a la Potencia");
            Raise = Convert.ToInt32(Console.ReadLine());

            //Cheando el resultado
            Result = Number;

            for (int i = 1; i < Raise; i++)
            {
                Result = Result * Number;
            }

            //Mostrando el resultado
            Console.WriteLine(Result);
        }
    }
}
