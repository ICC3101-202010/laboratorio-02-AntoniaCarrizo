﻿using System;
using System.Collections.Generic;


namespace Laboratorio2AntoniaCarrizo
{
    public class Espotifai
    {
         //Crear lista
         private List<Cancion> songsList = new List<Cancion>();

         //Constructor vacio de la clase espotiafai
         public Espotifai()
         { 
         }

        //Crear metodos pedidos 
        public bool AgregarCancion(Cancion cancion)
        {
            int m = 0;
            while (m < songsList.Count)
            {
                if (songsList[m].Informacion() == cancion.Informacion())
                {
                    return false;
                }
                else
                {
                    m++;
                }

            }
            songsList.Add(cancion);
            return true;


        }

         public void VerCanciones()
         {
             if (songsList.Count>0)
            { 
                 int i = 0;
                 int n = 1;
                 while (i < songsList.Count)
                 {
                     Console.WriteLine(n +") "+songsList[i].Informacion());
                     i++;
                     n++;
                 }
                 
            }
             else
             {
                 Console.WriteLine("no hay canciones");
             }
         }
        
        

    }
}

