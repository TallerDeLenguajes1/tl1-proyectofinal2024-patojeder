
namespace caracteristicasJugador{


public class FabricaDePersonajes{//ver de retornar la lista
    static public void CrearOponentes(){
        
        /*List<Personaje> listaOponentes= new List<Personaje>();
            var semilla = Environment.TickCount;
            var random = new Random(semilla); 

        for (int i = 0; i < 10; i++)
        {
                int tiponum= random.Next(0,4);
                //TiposDePj tipo= (TiposDePj)tiponum;
                        Personaje nuevoEnemigo=new Caracteristicas(){
                        Velocidad= random.Next(50,101),
                        //Tipo=tipo.ToString(),
                        Destreza=random.Next(50,101),
                        Fuerza=random.Next(50,101),
                        Nivel=random.Next(50,101),
                        Defensa=random.Next(50,101),
                        Salud= 100,
                        Edad=random.Next(0,301),
                        Nombre=Personaje.enemigos[random.Next(0,33)]
                        };


                listaOponentes.Add(nuevoEnemigo); 
                 Console.WriteLine($"Nombre: {listaOponentes[i].Nombre}, Tipo: {listaOponentes[i].Tipo}, Velocidad: {listaOponentes[i].Velocidad}, Fuerza: {listaOponentes[i].Fuerza}");         
        }*/

        List<Caracteristicas> listaOponentes= new List<Caracteristicas>();
            var semilla = Environment.TickCount;
            var random = new Random(semilla);

            for (int i = 0; i < 10; i++)
            {
                Caracteristicas nuevoEnemigo=new Caracteristicas(random.Next(50,101), random.Next(50,101), random.Next(50,101), random.Next(50,101), Caracteristicas.enemigos[random.Next(0,Caracteristicas.enemigos.Length)]);
                listaOponentes.Add(nuevoEnemigo);
                Console.WriteLine($"Nombre: {listaOponentes[i].Nombre}, Fuerza: {listaOponentes[i].Fuerza}, Velocidad: {listaOponentes[i].Velocidad}, Defensa: {listaOponentes[i].Defensa}, Destreza: {listaOponentes[i].Destreza}, Salud: {listaOponentes[i].Salud}, Nivel: {listaOponentes[i].Nivel}, Experiencia: {listaOponentes[i].Experiencia}");
            }




    }
}
}