// See https://aka.ms/new-console-template for more information
using caracteristicasJugador;

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


public static float AtaqueUsuario(int opcion, Caracteristicas jugador){
     var semilla = Environment.TickCount;
    var random = new Random(semilla);
    float ataqueEcuacion;
    float ataque;
    ataqueEcuacion= ((jugador.Fuerza * jugador.Velocidad + jugador.Destreza)/100)+jugador.Experiencia;
    float cteDeAjuste=400;
    switch (opcion)
    {   
        case 1:
        float coeficienteMiss= random.Next(80,100);
        ataque=coeficienteMiss / 100 * ataqueEcuacion/cteDeAjuste;
        return ataque;

        case 2:
        float coeficienteMiss2= random.Next(40,100);
        ataque=coeficienteMiss2 / 100 * ataqueEcuacion/cteDeAjuste;
        return ataque;


        case 3:
        float coeficienteMiss3= random.Next(1,100);
        ataque=coeficienteMiss3 / 100 * ataqueEcuacion/(cteDeAjuste/2);
        return ataque;

        default:
        return 0;
    }


}

public static float AtaqueMaquina(Caracteristicas jugador, Caracteristicas enemigo){
    float ataqueEcuacionMaquina=enemigo.Velocidad * enemigo.Fuerza * enemigo.Destreza/(100*jugador.Nivel);
    return ataqueEcuacionMaquina;
}


public static float PeleaDefensa(Caracteristicas combatiente){
    float defensa= combatiente.Destreza+combatiente.Velocidad+combatiente.Experiencia/280;
    return defensa;
}


public static int MecanicaPelea(Caracteristicas jugador, Caracteristicas enemigo){
    int opAtaque;
    float ataqueDelUsuario;
    float ataqueDeLaMaquina;
    float DanioProvocado;
    
        while (jugador.Salud>0 && enemigo.Salud>0)
        {
            opAtaque=SeleccionarAtaque();
            ataqueDelUsuario= AtaqueUsuario(opAtaque, jugador);
            DanioProvocado= ataqueDelUsuario- PeleaDefensa(enemigo);
            enemigo.Salud=enemigo.Salud - DanioProvocado;
            Console.WriteLine($"La Salud de tu enemigo ahora es de: {enemigo.Salud}");
            Console.WriteLine("Tu turno ha terminado. Le toca a tu enemigo");
            ataqueDeLaMaquina=AtaqueMaquina(jugador, enemigo) - PeleaDefensa(jugador);
            DanioProvocado=ataqueDeLaMaquina;
            jugador.Salud= jugador.Salud - DanioProvocado;
            Console.WriteLine($"Tu enemigo ataco infringiedote {DanioProvocado}");
            Console.WriteLine($"Tu salud ahora es de: {jugador.Salud}");
            Console.WriteLine("Es tu turno");

        }

        if (jugador.Salud <= 0)
        {
            Console.WriteLine("Tu Salud es menor que cero, has sido brutalmente derrotado, no tienes lo suficiente para ser un maestro pokemon.\nIntentalo de nuevo en otra ocacion.");
            return 0;
        }else
        {
            Console.WriteLine("Has Derrotado a tu primer enemnigo, pero tu camino no sera tan facil pequeño padawan, quedan rivales dificiles aun por vencer");
            jugador.Experiencia=jugador.Experiencia+5;
            jugador.Nivel++;
            return 1;
        }
}

public void TorneoPokemon(Caracteristicas jugador, Caracteristicas enemigo){
int vida=1;
        while (vida==1 && jugador.Nivel<=10)
        {
                    vida=MecanicaPelea(jugador, enemigo);
                      
        }

}

}