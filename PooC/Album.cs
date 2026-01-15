using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace POO_Proiect;
public class Album
{
    public Artist Singer { get; set; }
    public List<Song> Melodii { get; set; } = new List<Song>();
    public int Rating { get; set; }
    public void AlbumSongadd() { 
    //instructiune album
    }
}