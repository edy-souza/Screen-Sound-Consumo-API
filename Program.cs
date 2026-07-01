using System.Text.Json;
using Screen_sound_api.Filtros;
using Screen_sound_api.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        // LinqFiltro.FiltrarGeneroMusical(musicas);       
        // LinqOrder.ArtistasOrdenados(musicas); 
        // LinqFiltro.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        // LinqFiltro.FiltrarMusicasDeUmArtista(musicas, "U2");

        var musicasPreferidasdoDaniel = new MusicasPreferidas("Daniel");

        musicasPreferidasdoDaniel.AdcionarMusicasFavoritas(musicas[1]);
        musicasPreferidasdoDaniel.AdcionarMusicasFavoritas(musicas[25]);
        musicasPreferidasdoDaniel.AdcionarMusicasFavoritas(musicas[8]);
        musicasPreferidasdoDaniel.AdcionarMusicasFavoritas(musicas[60]);
        musicasPreferidasdoDaniel.AdcionarMusicasFavoritas(musicas[22]);
        musicasPreferidasdoDaniel.AdcionarMusicasFavoritas(musicas[19]);
        musicasPreferidasdoDaniel.AdcionarMusicasFavoritas(musicas[8]);
        musicasPreferidasdoDaniel.AdcionarMusicasFavoritas(musicas[726]);
        musicasPreferidasdoDaniel.AdcionarMusicasFavoritas(musicas[93]);
        musicasPreferidasdoDaniel.AdcionarMusicasFavoritas(musicas[4]);

        musicasPreferidasdoDaniel.ExibirMusicasFavoritas();
        musicasPreferidasdoDaniel.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema com a conexão da API {ex.Message}");
    }

}