using System.Text.Json.Serialization;

namespace ScreenSound_csharp_curso4.Models;

internal class Filme
{
    [JsonPropertyName("rank")] public string? Rank { get; set; }
    [JsonPropertyName("title")] public string? Titulo { get; set; }
    [JsonPropertyName("fullTitle")] public string? TituloCompleto { get; set; }
    [JsonPropertyName("year")] public string? Ano { get; set; }
    [JsonPropertyName("crew")] public string? Elenco { get; set; }

    public void ExibirDetalhesDoFilme()
    {
        Console.WriteLine($"Rank: {Rank}");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Título Completo: {TituloCompleto}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Elenco: {Elenco}\n");
    }
}