namespace MusicPoo;
public class Artist
{
    public string Nume { get; set; }
    public List<album> albums { get; set; }
    public Melodie melodie { get; set; }
    public string Follow { get; set; }
    public Artist(string nume, string follow)
    {
        Nume = nume;
        Follow = follow;
    }
}