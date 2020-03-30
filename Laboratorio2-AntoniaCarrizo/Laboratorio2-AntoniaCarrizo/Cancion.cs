using System;
namespace Laboratorio2AntoniaCarrizo
{
    public class Cancion
    {
        //atributos
        private string name;
        private string album;
        private string artist;
        private string gender;

        //Propiedades get y set para acceder a los datos
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;

            }
        }

        public string Album
        {
            get
            {
                return this.album;
            }
            set
            {
                this.album = value;

            }
        }

        public string Artist
        {
            get
            {
                return this.artist;
            }
            set
            {
                this.artist = value;

            }
        }

        public string Gender 
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;

            }
        }

        //Constructor con parametros de informacion de la cancion

        public Cancion(string name, string album, string artist, string gender)
        {
            this.Name = name;
            this.Album = album;
            this.Artist = artist;
            this.Gender = gender;
        }

        //metodo pedido en enunciado que nos retornara la informacion 

        public String Informacion()
        {
            return "genero: " + Gender + ", artista: " + Artist + ", album: " + Album +  ", nombre: " + Name;
        }
        

    }
}
