using System;
using System.Collections.Generic;


namespace Laboratorio2AntoniaCarrizo
{
    public class Espotifai
    {
         //Crear lista
        private List<Cancion> songsList = new List<Cancion>();
        private List<Playlist> almacenarPlaylist = new List<Playlist>();


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

        public bool GenerarPlaylist(String criterio, String valorCriterio, String nombrePlaylist)
        {
            
            List<Cancion> listcriterios = CancionesPorCriterio(criterio,valorCriterio); 
            

            int i = 0;
            while (i < almacenarPlaylist.Count)
            {
                if (nombrePlaylist == almacenarPlaylist[i].NamePlaylist)
                {
                    Console.WriteLine("La playlist con el nombre dado ya existe");
                    return false;
                }
                i++;
            }

            if (listcriterios.Count > 0)
            {
                Playlist playlist = new Playlist(nombrePlaylist, listcriterios);
                almacenarPlaylist.Add(playlist);
                Console.WriteLine(playlist.InformacionPlaylist()); //Esta lina esta mal
                return true;
            }
            else
            {
                Console.WriteLine("No existen canciones para este criterio"); 
                return false;
            }
            

        }


        public String VerMisPlaylists()
        {
            string str = "";
            int i = 0;
            int j = 1;
            if (almacenarPlaylist.Count > 0)
            {
                Console.WriteLine("La informacion de las playlists es: ");
                while (i < almacenarPlaylist.Count)
                {
                    str += "[" + j + "] \n" + almacenarPlaylist[i].InformacionPlaylist() + "\n";
                    i++;
                    j++;
                }
            }
            else
            {
                Console.WriteLine("No hay playlist");
            }
            return str;
        }

    }
}

