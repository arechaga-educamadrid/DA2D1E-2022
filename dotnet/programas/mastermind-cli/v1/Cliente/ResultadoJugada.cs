using System.Text.Json.Serialization;

public class ResultadoJugada
{
    [property: JsonPropertyName("numeroJugada")]
    public int NumeroJugada { get; set; }

    [property: JsonPropertyName("resultado")]
    public string[] Resultado { get ; set; } = Array.Empty<string>();

    [property: JsonPropertyName("esGanador")]
    public bool EsGanador { get; set; }

    [property: JsonPropertyName("caducidad")]
    public DateTime Caducidad { get ; set;}
} // class ResultadoJugada