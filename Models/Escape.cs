public class Escape
{
    private static  List<string> incognitasSalas =  new List<string> () {"si","MYSTERY SHACK","LA RECETA DE PIE DE MANZANA","OJOS DECORATIVOS","GRENDA Y CANDY", "5703"};
    private static int estadoJuego = 1;
    public static string nombJugador { get; set; } = "Jugador1";
    public static int NumError { get; set; } = 0;
    private static void InicializarJuego()
    {
        string[] incognitasSalas = {"Si"};
    }

    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }
    
    public static bool ResolverSala(int sala, string Incognita)
    {
        if(estadoJuego == sala)
        {
            #if true
                if (incognitasSalas[sala - 1] == Incognita)
            #endif
            {
                estadoJuego++;
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}