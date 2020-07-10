using System;
using System.Collections.Generic;

//Jannabel Ramos Ramirez 2019-8510.

/* Crear una aplicación para un sistema de votaciones. 

Caracteristicas:
      - Cantidad de candidatos 4
      - Cantidad de votos 1,000, estos seran de forma aleatoria.
      - Los resultados se mostraran 
      (Total de votos por candidatos, % de votos acumulados y Ordenados descendente).
      - El sistema es tipo consola en C#.
      - Datos candidato: Partido, Nombre completo, poscición a la que aspira (presidente).
      - Partidos: Fecha de fundacion (ficticia), Nombre completo y siglas*/

namespace Sistema_de_votacion
{
    class Program
    {

      

        static void Main(string[] args)
        {
            var elecciones = new elecciones();
            var Candidato1 = new Candidato();
            var Candidato2 = new Candidato();
            var Candidato3 = new Candidato();
            var Candidato4 = new Candidato();

            Candidato1.Nombre = " Joaquin Santos";
            Candidato1.Cargo = " Presidente";
            Candidato1.Nombre_Partido = " Jovenes Modernos ";
            Candidato1.Siglas_Partido = "JOMOD";
            Candidato1.Fundacion_Partido = "2010";

            Candidato2.Nombre = " Martha De Jesús";
            Candidato2.Cargo = " Presidente";
            Candidato2.Nombre_Partido = "Union Civica Nacional";
            Candidato2.Siglas_Partido = "UCN";
            Candidato2.Fundacion_Partido = "2005";

            Candidato3.Nombre = " Luz Alcantara";
            Candidato3.Cargo = " Presidente";
            Candidato3.Nombre_Partido = "Movimiento Popular";
            Candidato3.Siglas_Partido = "MP";
            Candidato3.Fundacion_Partido = "2007";


            Candidato4.Nombre = " Alberto Reyes";
            Candidato4.Cargo = " Presidente";
            Candidato4.Nombre_Partido = "Generacion para un Encuentro Nacional";
            Candidato4.Siglas_Partido = "GEN";
            Candidato4.Fundacion_Partido = "2015";


            float c1=0, c2 = 0, c3 = 0, c4 = 0;
            float p1, p2 , p3 , p4;

            for (int votos=1; votos<=1000; votos++)
            {
             var votantes = new Random().Next(1, 5);
                switch (votantes)
                {
                    case 1:
                        c1++;
                        break;
                    case 2:
                        c2++;
                        break;
                    case 3:
                        c3++;
                        break;
                    case 4:
                        c4++;
                        break;
                }
            }

     
            p1 = ((c1/ 1000) * 100);
            p2 = (c2 / 1000) * 100;
            p3 = (c3 / 1000) * 100;
            p4 = (c4 / 1000) * 100;

            Candidato1.votos = c1;
            Candidato2.votos = c2;
            Candidato3.votos = c3;
            Candidato4.votos = c4;

            Candidato1.pvotos = p1;
            Candidato2.pvotos = p2;
            Candidato3.pvotos = p3;
            Candidato4.pvotos = p4;

            float[] votoss = { 0, c1, c2, c3, c4, 0 };

            Array.Sort(votoss);
            Array.Reverse(votoss);
            int posicion;

            for (int i = 0; i <6; i++)
            {
                posicion = i+1;
                if (votoss[i] == c1)
                {
                    Console.Clear();
                    elecciones.Resultados(Candidato1.Nombre, Candidato1.Cargo, Candidato1.Nombre_Partido, Candidato1.votos, Candidato1.pvotos, Candidato1.Fundacion_Partido, posicion);
                    Console.ReadKey();
                                    
                }
                else if (votoss[i] == c2)
                {
                    Console.Clear();
                    elecciones.Resultados(Candidato2.Nombre, Candidato2.Cargo, Candidato2.Nombre_Partido, Candidato2.votos, Candidato2.pvotos, Candidato2.Fundacion_Partido, posicion);
                    Console.ReadKey();
                    
                }
                else if (votoss[i] == c3)
                {
                    Console.Clear();
                    elecciones.Resultados(Candidato3.Nombre, Candidato3.Cargo, Candidato3.Nombre_Partido, Candidato3.votos, Candidato3.pvotos, Candidato3.Fundacion_Partido, posicion);
                    Console.ReadKey();
                    
                }
                else if (votoss[i] == c4)
                {
                    Console.Clear();
                    elecciones.Resultados(Candidato4.Nombre, Candidato4.Cargo, Candidato4.Nombre_Partido, Candidato4.votos, Candidato4.pvotos, Candidato4.Fundacion_Partido, posicion);
                    Console.ReadKey();
                    
                }
            }
        }

    }
}
