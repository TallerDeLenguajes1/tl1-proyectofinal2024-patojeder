// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using caracteristicasJugador;


public class PersonajesJson
    {
        public static void GuardarPersonajes(List<Caracteristicas> personajes, string nombreArchivo)
        {
            try
            {
                string directorio = Path.GetDirectoryName(nombreArchivo);//no hace falta(?)

                if (!Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                }
                string jsonString = JsonSerializer.Serialize(personajes);
                File.WriteAllText(nombreArchivo, jsonString);
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
                return JsonSerializer.Deserialize<List<Caracteristicas>>(jsonString);
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