using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace POO_Proiect;
public class Listener(string nume) : Persoana(nume){ 
    public List<Playlist> AllPlaylists { get; set; } = new List<Playlist>();
    public List<Song> MelodiiAp { get; set; } = new List<Song>();
    public List<Song> Playlist { get; set; } = new List<Song>();
    public void LikedSong(Song melodie)
    {
        MelodiiAp.Add(melodie);
    }
    public void AddToPlaylist(Playlist playlistAles,Song melodie)
    {
        playlistAles.Melodii.Add(melodie);
    }
    public void NewPlaylist(Playlist np) {
        AllPlaylists.Add(np);
    }
    public void Asculta_Melodie(Song melodie)
    {
        Console.WriteLine($"{Nume}asculta:{melodie.Title}");
        melodie.Played();
    }
    public void RateAlbum(Album album)
    {
        Console.WriteLine("Adaugati rating:");
        string srating = Console.ReadLine();
        album.Rating = int.Parse(srating);
    }
    public void Follow()
    {
        //instructiune follow
    }
    public void TopSongs()
    {
        //instructiune Top
    }
}