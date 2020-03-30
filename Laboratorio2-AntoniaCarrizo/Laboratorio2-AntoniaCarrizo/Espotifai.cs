using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2AntoniaCarrizo
{
    public class Espotifai
    {
       private List<Cancion> songsList = new List<Cancion>();


        //Constructor vacio de la clase espotiafai
        public Espotifai()
        { 
        }
        

       
         public bool AgregarCancion(Cancion cancion)
         {
             if (songsList.Contains(cancion) == true)
             {
                 return false;
             }
             else
             {
                 songsList.Add(cancion);
                 return true;
             }
         }

         public void VerCanciones()
         {
             if (songsList.Count>0)
             {
                 int i = 0;
                 while (i < songsList.Count)
                 {
                     Console.WriteLine(i+") "+songsList[i]);
                     i++;
                 }

             }
             else
             {
                 Console.WriteLine("no hay canciones");
             }
         }

         public Cancion[] CancionesPorCriterio(String criterio, String valor)
        {

        }


    }
}

