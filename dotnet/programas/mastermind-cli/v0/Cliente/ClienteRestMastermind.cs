public class ClienteRestMastermind : ClienteRest
{
    public ClienteRestMastermind(string urlBase) : base (urlBase)
    {
        // en blanco
    } // constructor

    public async Task<Guid> NuevaPartida(ConfiguracionPartida configuracion)
    {
        if (IsDisposed) throw new ObjectDisposedException(nameof(ClienteRestMastermind));

        return Guid.Empty;
    } // NuevaPartida

    public async Task<ResultadoJugada> RealizarJugada(Guid idPartida, Jugada jugada)
    {
        if (IsDisposed) throw new ObjectDisposedException(nameof(ClienteRestMastermind));

        return new ResultadoJugada();
    } // realizarJugada
} // class ClienteRestMastermind