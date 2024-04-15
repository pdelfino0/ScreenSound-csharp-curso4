using System.Text.Json;
using ScreenSound_csharp_curso4.Models;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync(
            "https://guilhermeonrails.github.io/api-chsarp-songs/songs.json");
        List<Musica> musicas = JsonSerializer.Deserialize<List<Musica>>(response)!;
        foreach (Musica musica in musicas)
        {
            musica.ExibirDetalhesDaMusica();
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync(
            "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        List<Filme> filmes = JsonSerializer.Deserialize<List<Filme>>(response)!;
        foreach (Filme filme in filmes)
        {
            filme.ExibirDetalhesDoFilme();
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync(
            "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        List<Pais> paises = JsonSerializer.Deserialize<List<Pais>>(response)!;
        foreach (Pais pais in paises)
        {
            pais.ExibirDetalhesDoPais();
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}