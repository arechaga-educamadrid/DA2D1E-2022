internal class Program
{
    const string UrlBaseServidorMastermind = "http://localhost:5000/";
    static ConfiguracionPartida? _configuracion;

    private static void Main()
    {
        //Console.WriteLine("Hello, World!");

        _configuracion = CrearConfiguracionDefecto();
        ConfigurarPartida();

        var haGanado = false;
        while (!haGanado)
        {
            var jugada = ObtenerJugada();
            var resultado = RealizarJugada();
            MostrarResultado(jugada, resultado);
        } // while
    } // Main

    private static ConfiguracionPartida CrearConfiguracionDefecto()
    {
        return new ConfiguracionPartida()
        {

        };
    } // CrearConfiguracionDefecto

    private static void ConfigurarPartida()
    {
        int minimo;
        int maximo;
        int casillas;

        Console.WriteLine($"La configuración del juego es:");
        Console.WriteLine($"Valor mínimo:");
        Console.WriteLine($"Valor máximo:");
        Console.WriteLine($"Número de casillas:");
        Console.WriteLine();

        Console.Write("¿Quieres cambiar la configuración? (S/N) ");
        var tecla = Console.ReadLine()?.ToUpper();

        if (tecla != "S") return;

        var esCorrecto = false;
        while (!esCorrecto) 
        {
            Console.Write("Valor mínimo: ");
            var texto = Console.ReadLine();
            if (int.TryParse(texto, out minimo))
            {
                esCorrecto = true;
                continue;
            }
            else
            {
                Console.WriteLine("Número erróneo");
            } // if-else
        } // while

        esCorrecto = false;
        while (!esCorrecto) 
        {
            Console.Write("Valor máximo: ");
            var texto = Console.ReadLine();
            if (int.TryParse(texto, out maximo))
            {
                esCorrecto = true;
                continue;
            }
            else
            {
                Console.WriteLine("Número erróneo");
            } // if-else
        } // while

        esCorrecto = false;
        while (!esCorrecto) 
        {
            Console.Write("Número de casillas: ");
            var texto = Console.ReadLine();
            if (int.TryParse(texto, out casillas))
            {
                if ((casillas >=1) && (casillas <=100))
                {
                    esCorrecto = true;
                    break;
                } // if
            } // if

            Console.WriteLine("Número erróneo");
        } // while

        _configuracion = new ConfiguracionPartida()
        {

        };
    } // ConfigurarPartida

    private static Jugada ObtenerJugada()
    {
        return null;
    } // ObtenerJugada

    private static ResultadoJugada RealizarJugada()
    {
        return null;
    } // RealizarJugada

    private static void MostrarResultado(Jugada jugada, ResultadoJugada resultado)
    {

    } // MostrarResultado
} // class Program
