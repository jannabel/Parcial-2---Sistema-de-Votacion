using System;

        public struct Candidato
        {

            public String Nombre;
            public String Cargo;
            public float votos;
            public float pvotos;
            public String Nombre_Partido;
            public String Siglas_Partido;
            public String Fundacion_Partido;


}
 
public class elecciones
{
    public void Resultados(string nombre, string cargo, string partido, float votos,  float porcentaje, string fundacion, int posicion)
    {

        Console.WriteLine("\n ~ Partido: {0}    ||   Fundacion: {1} ", partido, fundacion);
        Console.WriteLine("\n ~ Nombre: " + nombre);
        Console.WriteLine(" ~ Cargo:  " + cargo);

        Console.WriteLine("\n ~ Cantidad de votos: " + votos);
        Console.WriteLine(" % de votos obtenidos:" + porcentaje.ToString("0.00") + "%");
        Console.WriteLine("\n ~ Posicion numero: " + posicion+ " de 4");
    }
}
