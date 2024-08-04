// See https://aka.ms/new-console-template for more information
using caracteristicasJugador;
namespace configuracionDePelea
{
    
public class Pelea{

public static int SeleccionarAtaque(){
int opcion;
do
{

    Console.WriteLine("\n Es tu turno. Selecciona el ataque a realizar");
    Console.WriteLine("Ataque 1: Puñetazo");
    Console.WriteLine("Ataque 2: ");
    Console.WriteLine("Ataque 3: ");
    string op= Console.ReadLine();
    int.TryParse(op, out opcion);

    if (opcion <=0 || opcion >3)
    {
        Console.WriteLine("Ingrese un ataque valido (1 , 2 o 3)");
    }
    
} while (opcion <=0 || opcion >3);

return opcion;

}

//controlar ecuaciones de daño
public static float AtaqueUsuario(int opcion, Caracteristicas jugador){
    var semilla = Environment.TickCount;
    var random = new Random(semilla);
    float ataqueEcuacion;
    ataqueEcuacion= jugador.Fuerza * jugador.Velocidad / (float)Math.Sqrt(jugador.Destreza)+100 + jugador.Experiencia;// me sirve para trabajar con floaty no con double
    float cteDeAjuste=400;
    switch (opcion)
    {   
        case 1:
        float coeficienteMiss= random.Next(90,100);
        return coeficienteMiss / 100 * ataqueEcuacion/cteDeAjuste - 170;

        case 2:
        float coeficienteMiss2= random.Next(40,100);
        return coeficienteMiss2 / 100 * ataqueEcuacion/cteDeAjuste - 150;

        case 3:
        float coeficienteMiss3= random.Next(1,100);
        return coeficienteMiss3 / 100 * ataqueEcuacion/(cteDeAjuste/2) - 200;

        default:
        return 0;
    }

}

public static float AtaqueMaquina(Caracteristicas jugador, Caracteristicas enemigo){
    return enemigo.Velocidad * enemigo.Fuerza /(100+jugador.Nivel) - 50;

}


public static float PeleaDefensa(Caracteristicas combatiente){
    return (combatiente.Destreza+combatiente.Velocidad)/100 * 5;

}


public static int MecanicaPelea(Caracteristicas jugador, Caracteristicas enemigo){
    int opAtaque;
    float ataqueDelUsuario;
    float ataqueDeLaMaquina;
    float DanioProvocado;
    
        while (jugador.Salud>0 && enemigo.Salud>0)
        {//separa los turnos x if

        if (jugador.Salud>0)
        {
            Console.WriteLine("\nEs tu turno");
            opAtaque=SeleccionarAtaque();
            ataqueDelUsuario= AtaqueUsuario(opAtaque, jugador);
            DanioProvocado= ataqueDelUsuario - PeleaDefensa(enemigo);
            enemigo.Salud=enemigo.Salud - DanioProvocado;
            Console.WriteLine($"La Salud de tu enemigo ahora es de: {enemigo.Salud} % HP");
                        

        }

        if (enemigo.Salud>0)
        {
            Console.WriteLine("\nTu turno ha terminado. Le toca a tu enemigo\n");
            ataqueDeLaMaquina=AtaqueMaquina(jugador, enemigo) - PeleaDefensa(jugador);
            DanioProvocado=ataqueDeLaMaquina;
            jugador.Salud= jugador.Salud - DanioProvocado;
            Console.WriteLine($"Tu enemigo ataco infringiedote {DanioProvocado} de danio");
            Console.WriteLine($"Tu salud ahora es de: {jugador.Salud} % HP");


        }

            //contemplar que el daño provocado puede aumentar la salud? 
        }

        if (jugador.Salud <= 0)
        {
            Console.WriteLine("Tu Salud es menor que cero, has sido brutalmente derrotado, no tienes lo suficiente para ser un maestro pokemon.\nIntentalo de nuevo en otra ocacion.");
            return 0;
        }else
        {
            Console.WriteLine("Has Derrotado a tu primer enemnigo, pero tu camino no sera tan facil pequeño padawan, quedan rivales dificiles aun por vencer");
            jugador.Experiencia=jugador.Experiencia+5;
            jugador.Salud=100;
            jugador.Nivel=jugador.Nivel + 1;
            return 1;
        }
}

public static void TorneoPokemon(Caracteristicas jugador, List<Caracteristicas> enemigo, Datos nuevoPlayer){

int vida=1;
int indiceEnemigoActual=0;

        while (vida==1 && jugador.Nivel<10 && indiceEnemigoActual < enemigo.Count)
        {           Console.WriteLine($"En la siguiente pelea te enfrentas a: {enemigo[indiceEnemigoActual].Nombre}");
                    vida=MecanicaPelea(jugador, enemigo[indiceEnemigoActual]);
                    indiceEnemigoActual++;
                    
        }

        if (jugador.Nivel==10)
        {
            Console.WriteLine("Felicidades, has alcanzado el nivel 10, te convertiste en un maestro pokemon.");
            Console.WriteLine($"{nuevoPlayer.Nombre} desde ahora en adelante formas parte de un selecto grupo");
            Console.WriteLine($"Cuando un entrenador pokemon escuche sobre {nuevoPlayer.Apodo}, sabra que fue un maestro pokemon de {nuevoPlayer.Edad} años que domino las batallas con su pokemon tipo {nuevoPlayer.Tipo}");
            HistorialJson.GuardarGanador(nuevoPlayer,"ganadores.txt");
        }else
        {
            Console.WriteLine("Intentalo en otra ocasion");
        }
}

}

}