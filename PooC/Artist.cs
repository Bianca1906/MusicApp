using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace POO_Proiect;
public class Artist
{
    public string Nume { get; set; }
    public List<Album> albums { get; set; } = new List<Album>();
    public Song Melodie { get; set; }
    public List<Persoana> Followeri= new List<Persoana>();
   
    public Artist(string nume, Song melodie)
    {
        Nume = nume;
        Melodie = melodie;
    }
}