namespace TP04_AhorcadoFinal.Models;
public static class Juego{
    public static int cantidadFallidos {get; private set;}

    public static string arriesgosFallidos {get; private set;}

    public static string palabra {get; private set;}

    public static string adivinados  {get; private set;}


    public static void setearPalabra(){
        palabra = "imaginacion";
        adivinados = "___________";
        arriesgosFallidos = "";
    }

    public static void verificarLetra(char letraIngresada)
    {
        bool aux = false;
        string auxiliar = "";
        for(int i = 0; i < palabra.Length; i++)
        {
            if(letraIngresada == palabra[i]){
                auxiliar += letraIngresada;
                aux = true;
            }
            else{
                auxiliar += adivinados[i];
            }
            
        }
        adivinados = auxiliar;
        if (aux==false) cantidadFallidos++;
        arriesgosFallidos += letraIngresada + " - ";
        
    }

    public static bool verificarPalabra(string palabraIngresada){
        bool aux = false;
        if (palabraIngresada == palabra){
            aux = true;
        }
        return aux;
    }

}