
namespace caracteristicasJugador{


public class FabricaDePersonajes{
    public static List<Caracteristicas> CrearOponentes(){
        

        List<Caracteristicas> listaOponentes= new List<Caracteristicas>();
            var semilla = Environment.TickCount;
            var random = new Random(semilla);

            for (int i = 0; i < 10; i++)
            {
                Caracteristicas nuevoEnemigo=new Caracteristicas(random.Next(50,101), random.Next(50,101), random.Next(50,101), random.Next(50,101), Caracteristicas.enemigos[random.Next(0,Caracteristicas.enemigos.Length)]);
                listaOponentes.Add(nuevoEnemigo);
            }

    return listaOponentes;

}

public static Caracteristicas CrearJugador(TiposDePj tipo){
            var semilla = Environment.TickCount;
            var random = new Random(semilla);
    switch (tipo)
    {
        case TiposDePj.agua:
        Caracteristicas nuevoAgua=new Caracteristicas(random.Next(50,80), random.Next(50,91), random.Next(80,101), random.Next(50,101), "Squirtle");
        return nuevoAgua;

        case TiposDePj.fuego:
        Caracteristicas nuevoFuego=new Caracteristicas(random.Next(70,101), random.Next(50,101), random.Next(70,101), random.Next(50,101), "Charmander");
        return nuevoFuego;

        case TiposDePj.hoja:
        Caracteristicas nuevoHoja=new Caracteristicas(random.Next(60,101), random.Next(80,101), random.Next(50,101), random.Next(50,101),"Bulbasaur");
        return nuevoHoja;

        case TiposDePj.rayo:
        Caracteristicas nuevoRayo=new Caracteristicas(random.Next(50,101), random.Next(80,101), random.Next(60,101), random.Next(50,81), "Pikachu");
        return nuevoRayo;

        default:
        return null;
    }

}


}



}