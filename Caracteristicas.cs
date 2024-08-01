namespace caracteristicasJugador
{
    public class Caracteristicas{

    private float experiencia;
    private float velocidad;
    private float destreza;
    private float fuerza;
    private int nivel;
    private float defensa;
    private float salud;
            private string nombre;

    public  float Velocidad { get => velocidad; set => velocidad = value; }
    public  float Destreza { get => destreza; set => destreza = value; }
    public  float Fuerza { get => fuerza; set => fuerza = value; }
    public  int Nivel { get => nivel; set => nivel = value; }
    public  float Defensa { get => defensa; set => defensa = value; }
    public  float Salud { get => salud; set => salud = value; }
    public float Experiencia { get => experiencia; set => experiencia = value; }
    public string Nombre { get => nombre; set => nombre = value; }

        public Caracteristicas(float velocidad, float destreza, float defensa, float fuerza, string nombre){
            Experiencia= 0;
            Fuerza=fuerza;
            Destreza=destreza;
            Defensa=defensa;
            Velocidad=velocidad;
            nivel=1;
            Salud=100;
            this.nombre=nombre;

    }


 public static string[] enemigos={"Sudogudo", "PayPal", "Helldry","Elon","Narutomon","Mewto", "DarkSide","Trump","Jaidel","Pangolin","Articuno","Unknown","Onix", "Camaleon", "BlackWarGreyMon", "Gauss", "Tom", "Vector", "Snake", "Harry", "Cheeta","MikeMon", "Zeus","DarkLord","Panteurus","Kundun","Tarkan","Devias","Noria","Kanturu","Bakan","Crywolf","Chikorita","SoulMaster","Icarus","SkullKing","Snorlax","Parrot","Crocodile","Entei","Lapras","Gurymon","Lizard","Goblin","Conkeldurr","Cottonee","Drifloon","Dugtrio","Garbodor","Herdier","Klefki","Alakazam","Magmar","Gyarados","Zapdos","Moltres","Kabutops","Scyther","Lugia", "Ho-Oh", "Tyranitar","Suicune","Raikou","Blaziken", "Palkia","Dialga","Giratina","Arceus","Darkai","Infernape","Rayquaza","Zeref","Xerneas","Yveltal","Zygarde","Eternatus","Urshifu","Heatran","Cresselia","Thundurus","Kubfu","Enamorus","Natsu","Larcade","Dragneel","DressRossa","Shanks","Gildarts","Gajeel","Omnimon"}; 
     
}


}

