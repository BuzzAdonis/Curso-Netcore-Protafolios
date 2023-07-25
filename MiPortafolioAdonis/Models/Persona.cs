namespace MiPortafolioAdonis.Models;

public class Persona
{
    public String Nombre { get; set; }
    public int Edad { get; set; }
    public string Suscriptores { get; set; }
    public string Lenguaje { get; set; }
    public string Avatar { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }
    public double Imc { set; get; }
    public double puntos { get; set; } = 0.0;
    public double bono { get; set; }


}

