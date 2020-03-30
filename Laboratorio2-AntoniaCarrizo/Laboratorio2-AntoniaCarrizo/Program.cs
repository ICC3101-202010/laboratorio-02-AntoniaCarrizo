using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2AntoniaCarrizo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido usuario");
            Espotifai list = new Espotifai();
            while (true) {
                

                Console.WriteLine("El menu es: \n (1)Ver canciones \n (2)Agregar Cancion \n (3)Salir del programa \n Seleccione una opcion: ");
                string option = Console.ReadLine();
                

                if (option == "1")
                {
                    list.VerCanciones();

                }
                if (option == "2")
                {
                    Console.WriteLine("Inserte los datos de la cancion: \n 1)Nombre \n 2)Album \n 3)Artista \n 4)Genero");
                    string nam = Console.ReadLine();
                    string alb = Console.ReadLine();
                    string art = Console.ReadLine();
                    string gen = Console.ReadLine();
                    Cancion cancion = new Cancion(nam, alb, art, gen);
                    Console.WriteLine(cancion.Informacion());
                    list.AgregarCancion(cancion);
                    
                }
                if (option== "3")
                {
                    break;

                }
                if (option!="1" && option != "2" && option != "3")
                {
                    Console.WriteLine("La opcion no es correcta, vuelva a ingresarla");
                }
            }

           


            
        }
    }
}
