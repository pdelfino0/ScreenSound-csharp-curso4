using System.Text;
using System.Text.Json;

namespace ScreenSound_csharp_curso4.Models;

internal class Playlist
{
    public string? Nome { get; set; }
    public List<Musica> Musicas { get; }


    public Playlist(string? nome)
    {
        Nome = nome;
        Musicas = new List<Musica>();
    }

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }

    public void AdicionarMusicas(List<Musica> musicas)
    {
        Musicas.AddRange(musicas);
    }

    public void ExibirMusicasPlaylist()
    {
        Musicas.ForEach(m => m.ExibirDetalhesDaMusica());
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(this);
        File.WriteAllText("playlist.json", json);
        //encoding: UTF8Encoding() é opcional, pois o padrão é UTF8

        Console.WriteLine("Arquivo gerado com sucesso!");
        Console.WriteLine(Path.GetFullPath(json));
    }
}