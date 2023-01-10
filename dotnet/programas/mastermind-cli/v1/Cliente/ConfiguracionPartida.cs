using System.Text.Json.Serialization;

public class ConfiguracionPartida
{
    [property: JsonPropertyName("minimo")]
    public int Minimo { get; set; }
    
    [property: JsonPropertyName("maximo")]
    public int Maximo { get; set; }

    [property: JsonPropertyName("casillas")]
    public int Casillas { get; set; }
} // class ConfiguracionPartida