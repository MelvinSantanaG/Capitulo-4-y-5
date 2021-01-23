using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo_4_y_5
{
    class Capitulo_5_Ejercicio_5
    {
        //Declarando la variable

        String Letter;
        int Number;

        public void Display()
        {
            //Pediendo el numero
            Letter = (Console.ReadLine());
            Number = Convert.ToInt32(Letter);

            if (Letter.IndexOf("1") >= 0)
            {
                Console.WriteLine("Uno");
            }

            if (Letter.IndexOf("2") >= 0)
            {
                Console.WriteLine("Dos");
            }

            if (Letter.IndexOf("3") >= 0)
            {
                Console.WriteLine("Tres");
            }

            if (Letter.IndexOf("4") >= 0)
            {
                Console.WriteLine("Cuatro");
            }

            if (Letter.IndexOf("5") >= 0)
            {
                Console.WriteLine("Cinco");
            }

            if (Letter.IndexOf("6") >= 0)
            {
                Console.WriteLine("Seis");
            }

            if (Letter.IndexOf("7") >= 0)
            {
                Console.WriteLine("Siete");
            }

            if (Letter.IndexOf("8") >= 0)
            {
                Console.WriteLine("Ocho");
            }

            if (Letter.IndexOf("9") >= 0)
            {
                Console.WriteLine("Nueve");
            }

            if (Letter.IndexOf("10") >= 0)
            {
                Console.WriteLine("Diez");
            }

        }
    }
}
