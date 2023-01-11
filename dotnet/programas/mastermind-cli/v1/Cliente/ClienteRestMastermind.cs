public class ClienteRestMastermind : ClienteRest
{
    public ClienteRestMastermind(string urlBase) : base (urlBase)
    {
        // en blanco
    } // constructor

    public async Task<Guid> NuevaPartidaAsync(ConfiguracionPartida configuracion)
    {
        if (IsDisposed) throw new ObjectDisposedException(nameof(ClienteRestMastermind));

        return Guid.Empty;
    } // NuevaPartidaAsync

    public async Task<ResultadoJugada> RealizarJugadaAsync(Guid idPartida, Jugada jugada)
    {
        if (IsDisposed) throw new ObjectDisposedException(nameof(ClienteRestMastermind));

        return new ResultadoJugada();
    } // realizarJugadaAsync
} // class ClienteRestMastermind