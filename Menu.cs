using caracteristicasJugador;
using configuracionDePelea;

namespace mensajes
{

public class Menu{

public static int ControlEdad(){
int edad;
    do
    {       
            Console.Write("Ingrese su edad, para ser considerada valida (0 a 100 años): ");
            string entrada = Console.ReadLine();
            int.TryParse(entrada, out edad);
            Console.Write(edad);
    } while (edad < 0 || edad > 125);


        return edad;
}

    public static DateTime ControlFechaNacimiento()
{
    DateTime fechaNacimiento;
    DateTime fechaMinima = new DateTime(1900, 1, 1); // 124/125 años

    while (true)
    {
        Console.Write("Ingrese la fecha de nacimiento (dd-MM-yyyy): ");
        string entrada = Console.ReadLine();
        if (DateTime.TryParseExact(entrada, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out fechaNacimiento))
        {
            if (fechaNacimiento >= fechaMinima && fechaNacimiento <= DateTime.Today)
            {
                return fechaNacimiento;
            }
            else
            {
                Console.WriteLine("La fecha ingresada no esta dentro del rango permitido. La fecha debe ser estar entre 01-01-1900 y hoy.");
            }
        }
        else
        {
            Console.WriteLine("La fecha ingresada no es valida. Asegurese de ingresar una fecha con el formato dd-MM-yyyy.");
        }
    }
}


    public static TiposDePj TipoElejido()
    {
        int tipo;
        while (true)
        {
            Console.WriteLine("Seleccione el tipo (\n0) Tipo Agua\n 1) Tipo Fuego\n 2) Tipo Hoja\n 3) Tipo Rayo): ");
            string input = Console.ReadLine();
            int.TryParse(input, out tipo);
            if (tipo >= 0 && tipo < 4)
            {
                return (TiposDePj)tipo;
            }
            else
            {
                Console.WriteLine("Tipo no valido. Por favor, ingrese un numero entre 0 y 3.");
            }
        }
    }       


    public static void IniciarPartida(List<Caracteristicas> enemigos)
    {
        Console.Write("Ingrese el nombre: ");
        string nombre = Console.ReadLine();

        int edad = ControlEdad();
        DateTime fechaNacimiento = ControlFechaNacimiento();
        Console.Write("Ingrese el apodo: ");
        string apodo = Console.ReadLine();
        TiposDePj tipo = TipoElejido();

        Console.WriteLine("\nDatos ingresados:");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Fecha de Nacimiento: {fechaNacimiento.ToShortDateString()}");
        Console.WriteLine($"Apodo: {apodo}");
        Console.WriteLine($"Tipo: {tipo}");
        Mensajes.ElegirPokemon(tipo);
        Datos nuevoPlayer= new Datos(nombre, apodo, edad, fechaNacimiento, tipo);
        Pelea.TorneoPokemon(FabricaDePersonajes.CrearJugador(tipo), enemigos, nuevoPlayer);
    }



    public static void mostrarGanadores(){
        List<Datos> ganadores= HistorialJson.LeerGanadores("ganadores.txt");
        int i=0;

        while (i < ganadores.Count)
        {
            Console.WriteLine("\n**************************");
            Console.WriteLine($"Nombre: {ganadores[i].Nombre}");
            Console.WriteLine($"Fecha de nacimiento: {ganadores[i].FechaNac.ToShortDateString()}");
            Console.WriteLine($"edad: {ganadores[i].Edad}");
            Console.WriteLine($"Apodo: {ganadores[i].Apodo}");
            Console.WriteLine($"Tipo de pokemon utilizado: {ganadores[i].Tipo}");
            Console.WriteLine($"Fecha de creacion de partida: {ganadores[i].FechaPartida.ToLongDateString()}");
            Console.WriteLine("\n**************************");
            i++;
        }


    }



      public static void MenuInicio(List<Caracteristicas> enemigos){

        int opcion;
        do
        {
            Console.WriteLine("\n 1) Empezar una nueva partida.\n 2) Consultar el historial de ganadores. \n 3) Salir. ");
            
            string op=Console.ReadLine();
            int.TryParse(op, out opcion);

            if (opcion <0 || opcion>3)
            {
                Console.WriteLine("Ingrese un numero valido");
                opcion=0;
            }
        } while (opcion==0);

        switch (opcion)
        {   case 1:
                    IniciarPartida(enemigos);
            break;

            case 2:
                    mostrarGanadores();
            break;
            default: break;
        }

        }

  }

}

