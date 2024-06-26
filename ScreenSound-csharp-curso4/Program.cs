﻿using System.Text.Json;
using ScreenSound_csharp_curso4.Filtros;
using ScreenSound_csharp_curso4.Models;

//Musica
using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync(
            "https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        List<Musica> musicas = JsonSerializer.Deserialize<List<Musica>>(response)!;
        // foreach (Musica musica in musicas)
        // {
        //     musica.ExibirDetalhesDaMusica();
        // }

        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirTodosOsArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "hip hop");
        // LinqFilter.FiltrarAsMusicasPorArtista(musicas, "Drake");

        Playlist playlist = new Playlist("Drake Only");

        playlist.AdicionarMusicas(musicas.FindAll(m => m.Artista == "Drake").ToList());
        playlist.ExibirMusicasPlaylist();

        playlist.GerarArquivoJson();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

//Filme
// using (HttpClient client = new HttpClient())
// {
//     try
//     {
//         string response = await client.GetStringAsync(
//             "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
//         List<Filme> filmes = JsonSerializer.Deserialize<List<Filme>>(response)!;
//         foreach (Filme filme in filmes)
//         {
//             filme.ExibirDetalhesDoFilme();
//         }
//     }
//     catch (Exception e)
//     {
//         Console.WriteLine(e.Message);
//     }
// }
//
// //Pais
// using (HttpClient client = new HttpClient())
// {
//     try
//     {
//         string response = await client.GetStringAsync(
//             "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
//         List<Pais> paises = JsonSerializer.Deserialize<List<Pais>>(response)!;
//         foreach (Pais pais in paises)
//         {
//             pais.ExibirDetalhesDoPais();
//         }
//     }
//     catch (Exception e)
//     {
//         Console.WriteLine(e.Message);
//     }