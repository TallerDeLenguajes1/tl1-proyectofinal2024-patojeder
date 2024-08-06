// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using caracteristicasJugador;
using EspacioApi;
namespace configuracionDePelea
{
    
public class Pelea{

public static int SeleccionarAtaque(List<Abilidad> habilidades){

int opcion;
do
{


    Console.WriteLine("\nEs tu turno. Selecciona el ataque a realizar");
    Console.WriteLine("Ataque 1: Puñetazo");

    Console.WriteLine($"Ataque especial 2: {habilidades[0].NombreAbilidad}");

    Console.WriteLine($"Ataque especial 3:  {habilidades[1].NombreAbilidad}");
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
    ataqueEcuacion= jugador.Fuerza * jugador.Velocidad * (float)Math.Sqrt(jugador.Destreza);// me sirve para trabajar con floaty no con double
    float cteDeAjuste=5000;
    switch (opcion)
    {   
        case 1:
        float coeficienteMiss= random.Next(30,70);
        return (coeficienteMiss / 100 * ataqueEcuacion/(cteDeAjuste-3000))+(jugador.Experiencia*jugador.Nivel/3);

        case 2:
        float coeficienteMiss2= random.Next(30,100);
        return (coeficienteMiss2 / 100 * ataqueEcuacion/(cteDeAjuste - 3500))+(jugador.Experiencia*jugador.Nivel/2);

        case 3:
        float coeficienteMiss3= random.Next(0,101);
        return (coeficienteMiss3 / 100 * ataqueEcuacion/(cteDeAjuste - 4000))+(jugador.Experiencia*jugador.Nivel);

        default:
        return 0;
    }

}

public static float AtaqueMaquina(Caracteristicas enemigo){

    return enemigo.Fuerza * enemigo.Velocidad * (float)Math.Sqrt(enemigo.Destreza)/5000 + enemigo.Nivel * (enemigo.Experiencia+1);

}


public static float PeleaDefensa(Caracteristicas combatiente){

    return (combatiente.Destreza+combatiente.Velocidad)/100 * 5;

}


public static int MecanicaPelea(Caracteristicas jugador, Caracteristicas enemigo, List<Abilidad> habilidades, string nombreDelPokemon){//devuelve int
    int opAtaque;
    float ataqueDelUsuario;
    float ataqueDeLaMaquina;
    float DanioProvocado;
    
        while (jugador.Salud>0 && enemigo.Salud>0)
        {//separa los turnos x if

        if (jugador.Salud>0)
        {

            Console.WriteLine("\nEs tu turno");
            opAtaque= SeleccionarAtaque(habilidades);
            ataqueDelUsuario= (float)Math.Round( AtaqueUsuario(opAtaque, jugador),2);
            DanioProvocado= (float)Math.Round(ataqueDelUsuario - PeleaDefensa(enemigo),2);
            DanioProvocado=(float)Math.Round(Math.Max(0,DanioProvocado),2);
            enemigo.Salud=(float)Math.Round(enemigo.Salud - DanioProvocado,2);

            Console.WriteLine($"\nTu ataque causo {DanioProvocado} de danio");

            if (enemigo.Salud>0)
            {

                Console.WriteLine($"\nLa Salud de tu enemigo ahora es de: {enemigo.Salud} % HP");                
            }                

        }

        if (enemigo.Salud>0)
        {
            Console.WriteLine("\nTu turno ha terminado. Le toca a tu enemigo\n");
            ataqueDeLaMaquina=(float)Math.Round(AtaqueMaquina(enemigo) - PeleaDefensa(jugador),2);
            DanioProvocado=(float)Math.Round(ataqueDeLaMaquina,2);
            DanioProvocado=(float)Math.Round(Math.Max(0,DanioProvocado),2);
            jugador.Salud= (float)Math.Round(jugador.Salud - DanioProvocado,2);
            Console.WriteLine($"\nTu enemigo ataco infringiedote {DanioProvocado} de danio");
            
            if (jugador.Salud>0)
            {

                Console.WriteLine($"\nTu salud ahora es de: {jugador.Salud} % HP");
            }
        }

            //controlar que sea un daño logico, pega muy poco a veces 
        }

        if (jugador.Salud <= 0)
        {

            Console.WriteLine("\nTu Salud ha llegado cero, has sido brutalmente derrotado, no tienes lo suficiente para ser un maestro pokemon.");
            return 0;
        }else
        {
            Console.WriteLine("\nHas Derrotado a tu enemnigo");
            jugador.Experiencia=jugador.Experiencia+2;
            jugador.Salud=100;
            jugador.Nivel=jugador.Nivel + 1;
            return 1;
        }
}

public static void TorneoPokemon(Caracteristicas jugador, List<Caracteristicas> enemigo, Datos nuevoPlayer, List<Abilidad> habilidades, string nombreDelPokemon){

int vida=1;
int indiceEnemigoActual=0;

        while (vida==1 && jugador.Nivel<10 && indiceEnemigoActual < enemigo.Count)
        {           Console.WriteLine($"\nEn la siguiente pelea se enfrenta tu {jugador.Nombre} VS {enemigo[indiceEnemigoActual].Nombre}");
                    vida=MecanicaPelea(jugador, enemigo[indiceEnemigoActual], habilidades, nombreDelPokemon);
                    indiceEnemigoActual++;
                    enemigo[indiceEnemigoActual].Experiencia=indiceEnemigoActual;
                    enemigo[indiceEnemigoActual].Nivel=indiceEnemigoActual;
        }

        if (jugador.Nivel==10)
        {
            Console.WriteLine("\nFelicidades, has alcanzado el nivel 10, te convertiste en un maestro pokemon.");
            Console.WriteLine($"\n{nuevoPlayer.Nombre}, desde ahora en adelante formas parte de un selecto grupo");
            Console.WriteLine($"\nCuando un entrenador pokemon escuche sobre {nuevoPlayer.Apodo}, sabra que fue un maestro pokemon de {nuevoPlayer.Edad} años que domino las batallas con su pokemon tipo {nuevoPlayer.Tipo}");
            HistorialJson.GuardarGanador(nuevoPlayer,"ganadores.txt");
        }else
        {
            Console.WriteLine("\nIntentalo en otra ocasion");
        }
}

}

}

