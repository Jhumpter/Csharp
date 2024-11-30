using System.Text.Json;
using ScreenSoundAPI.Models;
using ScreenSoundAPI.Filter;

using (HttpClient client = new HttpClient())
{
    try
    {
         string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
            //Methods with "async" mean that method won't return something immediately. This allows the application to continue other tasks while the processing isn't finished.
            //"Await" is used to wait for the task to be completed and assign the results to the variable
            //The command below converts the json into a manipulable object in C#. This process is called deserialization.
        var songs = JsonSerializer.Deserialize<List<Song>>(response)!;
        //Console.WriteLine(response);
        //LinqFilter.FilterAllGenres(songs);
        //LinqOrder.ShowOrdenedArtists(songs);
        LinqFilter.FilterArtirtsByGenre(songs, "metal"); //The function needs a list of songs and a musical genre
    }
    catch (Exception ex) 
    {
        Console.WriteLine($"We have a problem({ex.Message})");
        //ex.Message is a property of the exception that show the error's origin
    }
}
