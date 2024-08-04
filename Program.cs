// See https://aka.ms/new-console-template for more information
using caracteristicasJugador;
using mensajes;
using espacioPersonajesJson;

//FabricaDePersonajes.CrearOponentes();


if (PersonajesJson.Existe("personajes.txt"))
{
    Menu.MenuInicio(PersonajesJson.LeerPersonajes("personajes.txt"));
}else
{
   PersonajesJson.GuardarPersonajes(FabricaDePersonajes.CrearOponentes(), "personajes.txt");
   Menu.MenuInicio(PersonajesJson.LeerPersonajes("personajes.txt")); 
}


