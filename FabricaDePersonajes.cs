namespace fabricaPersonajes{
using caracteristicasJugador;


public class FabricaDePersonajes{
    static public void CrearOponentes(){
        
        List<Personaje> listaOponentes= new List<Personaje>();
            var semilla = Environment.TickCount;
            var random = new Random(semilla); 

        for (int i = 0; i < 10; i++)
        {
                int tiponum= random.Next(0,4);
                TiposDePj tipo= (TiposDePj)tiponum;
                        Personaje nuevoEnemigo=new Personaje(){
                        Velocidad= random.Next(100,1001)/100*10,
                        Tipo=tipo.ToString(),
                        Destreza=random.Next(100,601)/90*10,
                        Fuerza=random.Next(100,1001)/80*10,
                        Nivel=random.Next(100,1001)/100*10,
                        Defensa=random.Next(500,1001)/100,
                        Salud= 100
                        };
                listaOponentes.Add(nuevoEnemigo); 
                 Console.WriteLine($"Tipo: {listaOponentes[i].Tipo}, Velocidad: {listaOponentes[i].Velocidad}, Fuerza: {listaOponentes[i].Fuerza}");         
        }


    }


}
}