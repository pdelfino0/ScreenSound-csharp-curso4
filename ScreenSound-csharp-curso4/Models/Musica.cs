using System.Text.Json.Serialization;

namespace ScreenSound_csharp_curso4.Models;

internal class Musica
{
    [JsonPropertyName("artist")] public string? Artista { get; set; }
    [JsonPropertyName("song")] public string? Nome { get; set; }
    [JsonPropertyName("duration_ms")] public int Duracao { get; set; }
    [JsonPropertyName("genre")] public string? Genero { get; set; }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao}/1000");
        Console.WriteLine($"Gênero: {Genero}\n");
    }

    public static void FiltrarPorGeneroMusical(string genero, List<Musica> musicas)
    {
        musicas.FindAll(m => m.Genero == genero).ForEach(m => m.ExibirDetalhesDaMusica());
    }

    public static void OrdernarArtistasPorNome(List<Musica> musicas)
    {
        foreach (Musica musica in musicas.OrderBy(m => m.Artista))
        {
            musica.ExibirDetalhesDaMusica();
        }
    }

    public static List<string?> ExibirGenerosMusicais(List<Musica> musicas)
    {
        return musicas.Select(m => m.Genero).Distinct().ToList();
    }
}