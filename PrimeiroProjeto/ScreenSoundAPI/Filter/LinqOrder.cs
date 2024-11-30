using ScreenSoundAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSoundAPI.Filter;

internal class LinqOrder
{
    public static void ShowOrdenedArtists(List<Song> songs)
    {
        //OrderBy (ascendant) and OrderByDescending
        var artists = songs.OrderBy(song => song.Artist).Select(song => song.Artist).Distinct().ToList();
        foreach (var artist in artists) 
        {
            Console.WriteLine(artist);
        }
    }   
}