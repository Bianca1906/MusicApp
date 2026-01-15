using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace POO_Proiect;
public class Listener(string nume) : Persoana(nume)
{
    public List<Playlist> AllPlaylists { get; set; } = new List<Playlist>();
    public List<Song> MelodiiAp { get; set; } = new List<Song>();
    public List<Song> Playlist { get; set; } = new List<Song>();
    public List<Song> IstoricP { get; set; } = new List<Song>();
    public void LikedSongs(Song melodie)
    {
        MelodiiAp.Add(melodie);
    }
    public void AddToPlaylist(Playlist playlistAles, Song melodie)
    {
        playlistAles.Melodii.Add(melodie);
    }
    public void NewPlaylist(Playlist np)
    {
        AllPlaylists.Add(np);
    }
    public void Asculta_Melodie(Song melodie)
    {
        Console.WriteLine($"{Nume}asculta:{melodie.Title}");
        melodie.PlayedG(); //global
        IstoricP.Add(melodie); //se adauga in istoricul personal de ascultare
    }
    public int Lnr_ascultari(Song sg)
    {
        int cnt_p = 0;
        foreach (Song s in IstoricP)
        {
            if (s == sg)
            {
                cnt_p++;
            }
        }
        return cnt_p;
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
    public void Top5Songs()
    {
        List<Song> wdsongs = new List<Song>();
        foreach (Song sgi in IstoricP)
        {
            if (!wdsongs.Contains(sgi))
            {
                wdsongs.Add(sgi);
            }
        }
        int limit = 5;
        if (wdsongs.Count < 5) {
            limit = wdsongs.Count; 
        }
        for (int i = 0; i < limit; i++)
            {
                Song TopListened = wdsongs[0];
                int AscMax = Lnr_ascultari(TopListened);
                foreach (Song CrntS in wdsongs)
                {
                    int CrntP = Lnr_ascultari(CrntS);
                    if (CrntP > AscMax)
                    {
                        AscMax = CrntP;
                        TopListened = CrntS;
                    }
                }
                Console.WriteLine($"{i+1}. {TopListened.Title} - {AscMax} ascultări");
                wdsongs.Remove(TopListened);
            }
        }
}