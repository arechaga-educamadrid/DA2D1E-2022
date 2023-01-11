/*
https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/console-webapiclient
Tutorial: Make HTTP requests in a .NET console app using C#
*/
public class ClienteRest : IDisposable
{
    private HttpClient? _clienteHttp;

    public ClienteRest(string urlBase)
    {
        UrlBase = urlBase;
        _clienteHttp = new HttpClient();
    } // constructor

    public string UrlBase
    {
        get;
        protected set;
    } // UrlBase

    protected HttpClient ClienteHttp
    {
        get => _clienteHttp ?? throw new ObjectDisposedException(nameof(ClienteRest));
    } // ClienteHttp

    #region Implementación de IDisposable y del patrón Disposable

    protected virtual void Dispose(bool disposing)
    {
        if (!IsDisposed)
        {
            if (disposing)
            {
                // TODO: eliminar el estado administrado (objetos administrados)
            }

            // TODO: liberar los recursos no administrados (objetos no administrados) y reemplazar el finalizador
            // TODO: establecer los campos grandes como NULL

            _clienteHttp = null;

            IsDisposed = true;
        } // if
    } // Dispose

    // // TODO: reemplazar el finalizador solo si "Dispose(bool disposing)" tiene código para liberar los recursos no administrados
    // ~ClienteRest()
    // {
    //     // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    } // Dispose

    public bool IsDisposed { get ; private set; }

    #endregion
} // class ClienteRest