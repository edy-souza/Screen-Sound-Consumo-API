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
        LinqFiltro.FiltrarMusicasDeUmArtista(musicas, "U2");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema com a conexão da API {ex.Message}");
    }
   
}