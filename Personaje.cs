namespace caracteristicasJugador{
public enum TiposDePj{
            agua,
            fuego,
            hoja,
            rayo

}
 public class Personaje{

    private string tipo;
    private float velocidad;
    private float destreza;
    private float fuerza;
    private int nivel;
    private float defensa;
    private float salud;
    public  float Velocidad { get => velocidad; set => velocidad = value; }
    public  float Destreza { get => destreza; set => destreza = value; }
    public  float Fuerza { get => fuerza; set => fuerza = value; }
    public  int Nivel { get => nivel; set => nivel = value; }
    public  float Defensa { get => defensa; set => defensa = value; }
    public  float Salud { get => salud; set => salud = value; }
    public string  Tipo { get => tipo; set => tipo = value; }

    private string nombre;
    private string apodo;
    private DateTime fechaNac;
    private int edad; 
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apodo { get => apodo; set => apodo = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public  int Edad { get => edad; set => edad = value; }    

}

}
