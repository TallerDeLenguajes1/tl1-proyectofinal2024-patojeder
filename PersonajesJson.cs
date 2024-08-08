// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using caracteristicasJugador;
namespace espacioPersonajesJson{

public class PersonajesJson
    {
        public static void GuardarPersonajes(List<Caracteristicas> personajes, string nombreArchivo)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(personajes, new JsonSerializerOptions{WriteIndented = true});//si le agrego eso quda mas lindo a la vista
                File.WriteAllText(nombreArchivo, jsonString);
                //control
                Console.WriteLine("Personajes guardados exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar personajes: {ex.Message}");
            }
        }

        public static List<Caracteristicas> LeerPersonajes(string nombreArchivo)
        {
            try
            {
                if (!File.Exists(nombreArchivo))
                {
                   return null; 
                }    

                string jsonString = File.ReadAllText(nombreArchivo);
                List<Caracteristicas> personajes = JsonSerializer.Deserialize<List<Caracteristicas>>(jsonString);
                return personajes;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer personajes: {ex.Message}");
                return null;
            }
        }
        
        public static bool Existe(string nombreArchivo)
        {
            try
            {
                return File.Exists(nombreArchivo) && new FileInfo(nombreArchivo).Length > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al verificar existencia del archivo: {ex.Message}");
                return false;
            }
        }     


    }
}