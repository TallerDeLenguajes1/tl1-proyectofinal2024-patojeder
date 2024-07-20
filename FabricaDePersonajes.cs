namespace fabricaPersonajes{
using caracteristicasJugador;


public class FabricaDePersonajes{
    static public void CrearOponentes(){
        
        List<Personaje> listaOponentes= new List<Personaje>();
            var semilla = Environment.TickCount;
            var random = new Random(semilla); 

        for (int i = 0; i < 9; i++)
        {
                int tiponum= random.Next(0,4);
                TiposDePj tipo= (TiposDePj)tiponum;
                        Personaje nuevoEnemigo=new Personaje(){
                        Velocidad= random.Next(10,1001)/1000*10,
                        Tipo=tipo.ToString(),
                        Destreza=random.Next(10,601)/600*10,
                        Fuerza=random.Next(10,1001)/1000*1,
                        Nivel=random.Next(10,1001)/1000*1,
                        Defensa=random.Next(10,1001)/1000*1,
                        Salud= 100
                        };
                listaOponentes.Add(nuevoEnemigo);       
        }

    Console.WriteLine(listaOponentes);
    }


}
}