using System.Text.Json.Serialization;

public class Jugada
{
    [property: JsonPropertyName("numeros")]
    public int[] Numeros { get; set; } = Array.Empty<int>();
} // class Jugada