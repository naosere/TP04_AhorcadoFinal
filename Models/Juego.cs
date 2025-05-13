namespace TP04_AhorcadoFinal.Models;
public static class Juego{
    public static int cantidadFallidos {get; private set;}

    public static List<char> arriesgosFallidos {get; private set;}

    public static string palabra {get; private set;}

    public static string adivinados  {get; private set;}


    

    public static bool ingresoCorrecto(string letraIngresada){
        bool aux = false;
        if (letraIngresada.Length==1){
            aux = true;
        }
        return aux;
    }

    public static bool verificarLetra(char letraIngresada)
    {

        for(int i = 0; i <= palabra.Length; i++)
        {
            if(letraIngresada == palabra[i]){
                
            }
        }
    }
}