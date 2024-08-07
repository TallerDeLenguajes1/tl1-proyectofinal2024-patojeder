using System.ComponentModel.Design.Serialization;
using caracteristicasJugador;
using configuracionDePelea;
using EspacioApi;
namespace mensajes
{

public class Menu{

    public static int CalcularEdad(DateTime fechaNacimiento){
    int edad;
            DateTime fechaDeHoy = DateTime.Now;
            edad = fechaDeHoy.Year - fechaNacimiento.Year;

        if ( fechaDeHoy.DayOfYear < fechaNacimiento.DayOfYear)
        {
                return edad-1;
        }else
        {
                return edad;
        }

    }


    public static DateTime ControlFechaNacimiento(){

    DateTime fechaNacimiento;
    DateTime fechaMinima = new DateTime(1900, 1, 1);

    while (true)
    {
        Console.Write("\nIngrese la fecha de nacimiento (dd-MM-yyyy): ");
        string entrada = Console.ReadLine();
        if (DateTime.TryParseExact(entrada, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out fechaNacimiento))
        {
            if (fechaNacimiento >= fechaMinima && fechaNacimiento <= DateTime.Today)
            {
                return fechaNacimiento;
            }
            else
            {
                Console.WriteLine("\nLa fecha ingresada no esta dentro del rango permitido. La fecha debe ser estar entre 01-01-1900 y hoy.");
            }
        }
        else
        {
            Console.WriteLine("\nLa fecha ingresada no es valida. Asegurese de ingresar una fecha con el formato dd-MM-yyyy.");
        }
    }
}


    public static TiposDePj TipoElejido()
    {
        int tipo = 0;
        Console.WriteLine("Seleccione el tipo:\n0) Tipo Agua.\n 1) Tipo Fuego.\n 2) Tipo Hoja.\n 3) Tipo Rayo ");
        while(!int.TryParse(Console.ReadLine(), out tipo) && !(tipo>=0 && tipo<4)){
            Console.WriteLine("Tipo no valido. Por favor, ingrese un numero entre 0 y 3.");
        }
        return (TiposDePj)tipo;
    }      


    public static async Task IniciarPartida(List<Caracteristicas> enemigos){

        Console.Write("Ingrese el nombre: ");
        string nombre = Console.ReadLine();
        while (nombre=="" || nombre==" " || nombre==null)
        {
            Console.WriteLine("ingrese un nombre valido");
            nombre = Console.ReadLine();
        }

        
        DateTime fechaNacimiento = ControlFechaNacimiento();
        int edad = CalcularEdad(fechaNacimiento);
        Console.Write("Ingrese el apodo: ");
        string apodo = Console.ReadLine();
        while (apodo=="" || apodo==" " || apodo==null)
        {
            Console.WriteLine("Ingrese un apodo valido");
            apodo = Console.ReadLine();
        }

        TiposDePj tipo = TipoElejido();
        Console.WriteLine("*****************");
        Console.WriteLine("\nDatos ingresados:");
        Console.WriteLine($"Nombre: {nombre}"); 
        Console.WriteLine($"Fecha de Nacimiento: {fechaNacimiento.ToShortDateString()}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Apodo: {apodo}");
        Console.WriteLine($"Tipo: {tipo}");
        string nombreDelPokemon=Mensajes.ElegirPokemon(tipo);
        List<Abilidad> habilidades = await TrabajandoApi.ObtenerHabilidades(nombreDelPokemon);
        Console.WriteLine("**  ***************");
        
        Datos nuevoPlayer= new Datos(nombre, apodo, edad, fechaNacimiento, tipo);
        Pelea.TorneoPokemon(FabricaDePersonajes.CrearJugador(tipo), enemigos, nuevoPlayer, habilidades, nombreDelPokemon);
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



      public static async Task MenuInicio(List<Caracteristicas> enemigos){
        Mensajes.Biemvenido();

        int opcion;

        do
        {
            
     
        do
        {
            Mensajes.Menu();
            
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
                     await IniciarPartida(enemigos);
            break;

            case 2:

                    if (HistorialJson.Existe("ganadores.txt"))
                    {
                        mostrarGanadores();
                    }else
                    {
                        Console.WriteLine("\n Todavia no aparecieron entrenadores dignos");
                    }

            break;
            
            default: 
            break;
        }
        } while (opcion!=3);
    }

  }

}

