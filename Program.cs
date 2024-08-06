// See https://aka.ms/new-console-template for more information
using caracteristicasJugador;
using mensajes;
using espacioPersonajesJson;

if (PersonajesJson.Existe("personajes.txt"))
{
    await Menu.MenuInicio(PersonajesJson.LeerPersonajes("personajes.txt"));
}else
{
   PersonajesJson.GuardarPersonajes(FabricaDePersonajes.CrearOponentes(), "personajes.txt");
   await Menu.MenuInicio(PersonajesJson.LeerPersonajes("personajes.txt")); 
}

