using System;
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

        //Metodo para playlist
        public List<Cancion> CancionesPorCriterio(String criterio, String valor)
        {
            List<Cancion> Listcriterio = new List<Cancion>();
            if (criterio == "genero" || criterio == "GENERO" || criterio == "Genero" )
            {
                int j = 0;
                while (j < songsList.Count)
                {
                    if (songsList[j].Gender == valor)
                    {
                        Listcriterio.Add(songsList[j]);
                        
                    }
                    j++;
                    

                }
            }

            else if (criterio == "nombre" || criterio == "NOMBRE" || criterio == "Nombre" )
            {
                int j = 0;
                while (j < songsList.Count)
                {
                    if (songsList[j].Name == valor)
                    {
                        Listcriterio.Add(songsList[j]);
                    }
                    j++;

                }
            }

            else if (criterio == "artista" || criterio == "ARTISTA" || criterio == "Artista")
            {
                int j = 0;
                while (j < songsList.Count)
                {
                    if (songsList[j].Artist == valor)
                    {
                        Listcriterio.Add(songsList[j]);
                    }
                    j++;

                }
            }
            else if (criterio == "album" || criterio == "ALBUM" || criterio == "Album")
            {
                int j = 0;
                while (j < songsList.Count)
                {
                    if (songsList[j].Album == valor)
                    {
                        Listcriterio.Add(songsList[j]);
                    }
                    j++;

                }
            }
            else
            {
                Console.WriteLine("Error, el criterio no es valido");
                
            }


            return Listcriterio;

            
        }



    }
}

