using System;
using System.Collections.Generic;


namespace Laboratorio2AntoniaCarrizo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Espotifai agregarlista = new Espotifai();
            Console.WriteLine("Bienvenido usuario");
            Cancion c1 = new Cancion("ocean eyes", "dont smile at me", "Billie Eilish", "electropop");
            Cancion c2 = new Cancion("Dance Monkey", "Dance Monkey", "Tones and i", "electropop");
            Cancion c3 = new Cancion("Bang Bang Bang", "When the sun goes down", "Selena Gomez", "pop");
            agregarlista.AgregarCancion(c1);
            agregarlista.AgregarCancion(c2);
            agregarlista.AgregarCancion(c3);


            while (true) {
                
                Console.WriteLine("El menu es: \n (1)Ver canciones \n (2)Agregar Cancion  \n (3)Ver canciones por criterio \n (4)Crear playlist \n (5)Ver mis playlist \n (6)Salir del programa \n Seleccione una opcion: ");
                string option = Console.ReadLine();
                

                if (option == "1")
                {
                    agregarlista.VerCanciones();

                }
                if (option == "2")
                {
                    Console.WriteLine("Inserte los datos de la cancion: \n 1)Nombre \n 2)Album \n 3)Artista \n 4)Genero");
                    string nam = Console.ReadLine();
                    string alb = Console.ReadLine();
                    string art = Console.ReadLine();
                    string gen = Console.ReadLine();
                    Cancion cancion = new Cancion(nam, alb, art, gen);

                    if (agregarlista.AgregarCancion(cancion)== true)
                    {
                        Console.WriteLine("La cancion que agrego es: \n" + cancion.Informacion());
                    }
                    else
                    {
                        Console.WriteLine("La cancion ya estaba agregada anteriormente");
                    }
                 }

                if (option == "3")
                {
                    Console.WriteLine("Ingrese el tipo de criterio (nombre, album, artista, genero): ");
                    string criterio = Console.ReadLine();
                    Console.WriteLine("Ingrese criterio: ");
                    string valor = Console.ReadLine();
                   

                    if (agregarlista.CancionesPorCriterio(criterio, valor).Count > 0)
                    {
                        int q = 0;
                        int w = 1;
                        
                        
                        while (q < agregarlista.CancionesPorCriterio(criterio, valor).Count)
                        {

                            Console.WriteLine(w + ") " + agregarlista.CancionesPorCriterio(criterio, valor)[q].Informacion());
                            q++;
                            w++;

                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("No existen canciones para este criterio");
                    }

                }


                if (option=="4")
                {
                    Console.WriteLine("Ingrese nombre de la Playlist: ");
                    string nomplay = Console.ReadLine();
                    Console.WriteLine("Ingrese tipo de criterio (genero, album, artista, nombre): ");
                    string criplay = Console.ReadLine();
                    Console.WriteLine("Ingrese valor del criterio: ");
                    string valcriplay = Console.ReadLine();

                    agregarlista.GenerarPlaylist(criplay, valcriplay, nomplay);
                    

                }


               if (option=="5")
               {
                    Console.WriteLine(agregarlista.VerMisPlaylists());

               }



                if (option == "6")
                {
                    break;

                }


                if (option!="1" && option != "2" && option != "3" && option != "4" && option != "5" && option != "6")
                {
                    Console.WriteLine("La opcion no es correcta, vuelva a ingresarla");
                }
            }

           


            
        }
    }
}
