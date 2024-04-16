using ScreenSound_csharp_curso4.Models;

namespace ScreenSound_csharp_curso4.Filtros;

internal class LinqOrder
{
    public static void ExibirTodosOsArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(x => x.Artista).Select(m => m.Artista).Distinct().ToList();
        Console.WriteLine("Lista de artista ordenados");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}