using System;
using System.Collections.Generic;

namespace Laboratorio2AntoniaCarrizo
{
    public class Playlist
    {
        private string namePlaylist;
        private List<Cancion> listsongs = new List<Cancion>();

        //get y set para acceder a los datos
        public string NamePlaylist
        {
            get
            {
                return this.namePlaylist;
            }
            set
            {
                this.namePlaylist = value;

            }
        }

        public List<Cancion> Listsongs
        {
            get
            {
                return this.listsongs;
            }
            set
            {
                this.listsongs = value;

            }
        }




        //En los parametros iran los datos necesarios para crear el objeto
        //Necesitaremos un nombre para la playlst y una lista de canciones

        public Playlist(string namePlaylist, List<Cancion> listsongs)
        {
            this.NamePlaylist = namePlaylist;
            this.Listsongs = listsongs;
        }

        //metodos par ver informacion de la playlist
        public String InformacionPlaylist()
        {
            string inf = "";

            int f = 0;
            int g = 1;
            while (f < Listsongs.Count)
            {
                inf += g+") "+Listsongs[f].Informacion();
                inf += "\n";
                f++;
                g++;
            }


            if (Listsongs.Count == 0)
            {
                return "La playlist " + NamePlaylist + " no tiene canciones agregadas";
            }
            else
            {
                return "* Nombre de la playlist: " + NamePlaylist + "\n" + "* La cantidad de canciones agregadas es: " + Listsongs.Count + "\n"+"Las canciones son: \n" + ""+inf;
            }

        }

    }   
}
