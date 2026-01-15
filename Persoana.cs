using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace POO_Proiect;

public  abstract class Persoana { 
    public string Nume { get; set; }
    public List <Persoana> Followed { get; set; } = new List<Persoana>();
    public Persoana(string nume)
    {
        Nume = nume;
    }
}