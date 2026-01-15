using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Proiect;
public class Playlist
{
    public List<Song> Melodii{ get; set; } = new List<Song>();
    /* internal class Song
     {
     }*/
    public void Shuffle() {
        Random rng= new Random();
        int nr = Melodii.Count;
        while (nr > 1)
        {
            nr--;
            int k = rng.Next(nr + 1);
            Song t = Melodii[k];
            Melodii[k] = Melodii[nr];
            Melodii[nr] = t;
        }
    }
}
