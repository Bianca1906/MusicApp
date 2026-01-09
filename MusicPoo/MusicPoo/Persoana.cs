namespace MusicPoo;
class Persoana
{
    public string Nume { get; set; }
    public list<Listener> Followed { get; set; }
    public Persoana(string nume)
    {
        Nume = nume;
    }
}