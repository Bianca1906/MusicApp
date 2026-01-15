using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Proiect;

public class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public TimeSpan Duration { get; set; }
    public int NrAscultariG { get; set; } = 0;
    public string Gen { get; set; }
    public void PlayedG(){
        NrAscultariG++;
    }
    public Song(string title, string artist, TimeSpan duration)
    {
        Title = title;
        Artist = artist;
        Duration = duration;
    }
}
