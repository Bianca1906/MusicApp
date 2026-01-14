using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace POO_Proiect;
public class Listener(string nume) : Persoana(nume){ 
    public List<Playlist> Playlists { get; set; } = new List<Playlist>();
    public List<Song> MelodiiAp { get; set; } = new List<Song>();
}