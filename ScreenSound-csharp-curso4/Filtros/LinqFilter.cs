using ScreenSound_csharp_curso4.Models;

namespace ScreenSound_csharp_curso4.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(genero => genero.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical =
            musicas.Where(m => m.Genero!.Contains(genero)).Select(m => m.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo artistas pelo gênero musical {genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarAsMusicasPorArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas.Where(m => m.Artista!.Equals(artista)).ToList();
        foreach (var musica in musicasDoArtista)
        {
            musica.ExibirDetalhesDaMusica();
        }
    }
}