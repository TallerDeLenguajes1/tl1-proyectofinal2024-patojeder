// See https://aka.ms/new-console-template for more information
using caracteristicasJugador;
using System.Text.Json;
//CONTROLAR SI ESTE ARCHIVO ESTA BIEN
public class HistorialJson
{
        public static void GuardarGanador(Datos datosJugador, string nombreArchivo)
        {
            try
            {
                List<Datos> historial = new List<Datos>();

                if (File.Exists(nombreArchivo))
                {
                    string jsonStringExistente = File.ReadAllText(nombreArchivo);
                    historial = JsonSerializer.Deserialize<List<Datos>>(jsonStringExistente);
                }

                // agrego losdatos
                historial.Add(datosJugador);
                string jsonString = JsonSerializer.Serialize(historial);
                File.WriteAllText(nombreArchivo, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar el ganador: {ex.Message}");
            }
        }


        public static List<Datos> LeerGanadores(string nombreArchivo)
        {
            try
            {
                if (!File.Exists(nombreArchivo))
                {
                   return null; 
                }    

                string jsonString = File.ReadAllText(nombreArchivo);
                return JsonSerializer.Deserialize<List<Datos>>(jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer personajes: {ex.Message}");
                return null;
            }
        }        
        public static bool Existe(string nombreArchivo)//no hace falta usarla
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