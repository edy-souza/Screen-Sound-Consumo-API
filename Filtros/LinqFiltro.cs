using Screen_sound_api.Modelos;

namespace Screen_sound_api.Filtros;

internal class LinqFiltro
{
    public static void FiltrarGeneroMusical(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        Console.WriteLine(todosOsGenerosMusicais);

        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }
}