using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEMANA_4_Biblioteca;



namespace SENANA_4_Consola
{
     class Usolibreria
     {
          public static void SortedListCollection()
          {
            
            Console.WriteLine("Seleccione el elemento a crear: ");
            Console.WriteLine("1.SortedList ");
            var response = Console.ReadLine();

            if (response == "1")
            {
                SampleCollection.SortedListCollection();
            }
            else
            {
                Console.ReadKey();
            }
          }
            
     } 
 
}


       
          
    
