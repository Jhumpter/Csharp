using ScreenSoundAPI.Models;

namespace ScreenSoundAPI.Filter;

internal class LinqFilter
{
    public static void FilterAllGenres(List<Song> songs)
    {
        //Select() retrives all genres from the list "songs" using the property "Genre"
        //Distinct() ensures that each gender is selected only once from the entire list
        //ToList() adds all the distinct genres to a new list
        var genres = songs.Select(genres => genres.Genre).Distinct().ToList();
        foreach (var genre in genres)
        {
            Console.WriteLine(genre);
        }
    }
    
    public static void FilterArtirtsByGenre(List<Song> songs, string genre)
    {
        var artistsByGenre = songs.Where(song => song.Genre.Contains(genre)).Select(song => song.Artist).Distinct().ToList();
        foreach(var artist in artistsByGenre)
        {
            Console.WriteLine(artist);
        }
    }

    public static void FilterSongsByArtist(List<Song> songs, string artist)
    {
        var songsByArtist = songs.Where(song => song.Artist!.Equals(artist)).ToList();
        foreach(var song in songsByArtist)
        {
            Console.WriteLine(song.Name);
        }
    }
}
