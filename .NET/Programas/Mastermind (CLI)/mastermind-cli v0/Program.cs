const string UrlBaseServidorMastermind = "http://localhost:5000/";

//Console.WriteLine("Hello, World!");

var configuracion = ConfigurarPartida();
if (configuracion == null) return;

var haGanado = false;
while(!haGanado)
{
    var jugada = ObtenerJugada();
    var resultado = RealizarJugada();
    MostrarResultado(jugada, resultado);
} // while

static ConfiguracionPartida? ConfigurarPartida()
{
    return null;
} // ConfigurarPartida

static Jugada ObtenerJugada()
{
    return null;
} // ObtenerJugada

static ResultadoJugada RealizarJugada()
{
    return null;
} // RealizarJugada

static void MostrarResultado(Jugada jugada, ResultadoJugada resultado)
{

} // MostrarResultado
