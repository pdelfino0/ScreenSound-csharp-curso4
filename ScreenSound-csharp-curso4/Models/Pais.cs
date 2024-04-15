using System.Text.Json.Serialization;

namespace ScreenSound_csharp_curso4.Models;

public class Pais
{
    [JsonPropertyName("nome")] public string? Nome { get; set; }
    [JsonPropertyName("capital")] public string? Capital { get; set; }
    [JsonPropertyName("continente")] public string? Continente { get; set; }
    [JsonPropertyName("idioma")] public string? Idioma { get; set; }
    [JsonPropertyName("populacao")] public int? Populacao { get; set; }

    public void ExibirDetalhesDoPais()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Capital: {Capital}");
        Console.WriteLine($"Continente: {Continente}");
        Console.WriteLine($"Idioma: {Idioma}");
        Console.WriteLine($"População: {Populacao}\n");
    }
}