// See https://aka.ms/new-console-template for more information
using System.Text.Json;


namespace EspacioApi
{
    public class Abilidad
    {   private string nombreAbilidad;

        public string NombreAbilidad { get => nombreAbilidad; set => nombreAbilidad = value; }
    }

    public class TrabajandoApi
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<List<Abilidad>> ObtenerHabilidades(string nombreDelPokemon)
        {
            var habilidades = new List<Abilidad>();
            try
            {
                var url = $"https://pokeapi.co/api/v2/pokemon/{nombreDelPokemon}";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                var jsonDocument = JsonDocument.Parse(responseBody);
                if (jsonDocument.RootElement.TryGetProperty("abilities", out var ArregloDeHabilidades))
                {
                    foreach (var campoAbilidad in ArregloDeHabilidades.EnumerateArray())
                    {
                        var habilidadNombre = campoAbilidad.GetProperty("ability").GetProperty("name").GetString();
                        habilidades.Add(new Abilidad { NombreAbilidad = habilidadNombre });
                    }
                }
                else
                {
                    Console.WriteLine("El JSON no contiene la propiedad 'abilities'.");
                }
            }
            catch (HttpRequestException Exception)
            {
                Console.WriteLine($"Error al obtener las habilidades: {Exception.Message}");
            }

            return habilidades;
        }
    }



    
}


