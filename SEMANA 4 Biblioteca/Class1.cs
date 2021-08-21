using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_4_Biblioteca
{
    public class SampleCollection
    {

        public static void SortedListCollection()
        {
            
            List<object> lst = new List<object>();
            // capturar los elementos para almacenar dentro de una lista 

            Console.WriteLine("Selecciona un elemeto: ");
            Console.WriteLine("Blanco");
            Console.WriteLine("Azul");
            Console.WriteLine("Rojo");
            Console.WriteLine("Verde");
            Console.WriteLine("Morado");
            Console.WriteLine("Rosa");
            Console.WriteLine("naranja");
            Console.WriteLine("amarillo");
            Console.WriteLine("negro");
            Console.WriteLine("gris");
            Console.WriteLine("marrón");

            var response = Console.ReadLine();

            if (response == "Blanco")
            {
                Console.Write("La representación de el color es: Pureza, inocencia, paz y virtud");
            }

            if (response == "Azul")
            {
                Console.Write("La representación de el color es: Tranquilidad, frescura e inteligencia");
            }

            if (response == "Rojo")
            {
                Console.Write("La representación de el color es: Energía, furia, excitación y alegría ");
            }

            if (response == "Verde")
            {
                Console.Write("La representación de el color es: Esperanza, fertilidad y juventud");
            }

            if (response == "Morado")
            {
                Console.Write("La representación de el color es: Sofisticación, misterio, nostalgia, y espiritualidad");
            }

            if (response == "Rosa")
            {
                Console.Write("La representación de el color es: Dulzura, suavidad y seducción");
            }

            if (response == "Naranja")
            {
                Console.Write("La representación de el color es: Diversión, exótico o poco común");
            }

            if (response == "Amarillo")
            {
                Console.Write("La representación de el color es: Iluminación, felicidad, envidia, celos, incertidumbre y quietud");
            }

            if (response == "Negro")
            {
                Console.Write("La representación de el color es: Poder, muerte, elegancia, formalidad y sobriedad");
            }

            if (response == "Gris")
            {
                Console.Write("La representación de el color es: Paz, tenacidad, tranquilidad");
            }

            if (response == "Marrón")
            {
                Console.Write("La representación de el color es: Confortabilidad, humildad y equilibrio");
            }



            Console.ReadKey();


        }
    }
}