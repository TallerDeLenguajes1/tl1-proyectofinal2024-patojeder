
using System.Security.Cryptography.X509Certificates;
using caracteristicasJugador;

namespace mensajes
{
    public partial class Mensajes{

        public void MsjePokemon(){

        string pokemon=@"                 __.                 ,\
            _.----.        ____         ,'  _\   ___    ___     ____
        _,-'       `.     |    |  /`.   \,-'    |   \  /   |   |    \  |`.
        \      __    \    '-.  | /   `.  ___    |    \/    |   '-.   \ |  |
        \.    \ \   |  __  |  |/    ,','_  `.  |          | __  |    \|  |
          \    \/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |
            \     ,-'/  /   \    ,'   | \/ / ,`.|         /  /   \  |     |
            \    \ |   \_/  |   `-.  \    `'  /|  |    ||   \_/  | |\    |
              \    \ \      /       `-.`.___,-' |  |\  /| \      /  | |   |
              \    \ `.__,'|  |`-._    `|      |__| \/ |  `.__,'|  | |   |
                \_.-'       |__|    `-._ |              '-.|     '-.| |   |
                                        `'                            '-._|";

        Console.WriteLine(pokemon);

        }

        public void Biemvenido(){
          Console.WriteLine("Biemvenido a Pokemon combates Jhoto");
          //Console.WriteLine("Si un maestro pokemon quieres ser, deberas elegir a un fiel compañero: ");
        }








//***********************************************************************************************
  public static void ElegirPokemon(TiposDePj tipo){

  

        string bulbasur=@"
                    `;,;.;,;.;.'                                                        
                      ..:;:;::;:                                      
                ..--''' '' ' ' '''--.                                        
              /' .   .'        '.   .`\                                     
            | /    /            \   '.|                                      
            | |   :             :    :|                                      
          .'| |   :             :    :|                                      
        ,: /\ \.._\ __..===..__/_../ /`.                                     
        |'' |  :.|  `'          `'  |.'  ::.                                                    
        |   |  ''|    :'';          | ,  `''\                                     
        |.:  \/  | /'-.`'   ':'.-'\ |  \,   |                                     
        | '  /  /  | / |...   | \ |  |  |';'|                                     
        \ _ |:.|  |_\_|`.'   |_/_|  |.:| _ |                                     
        /,.,.|' \__       . .      __/ '|.,.,\                                      
            | ':`.`----._____.---'.'   |                                     
              \   `:'''-------'''' |   |                                      
              ',-,-',             .'-=,=,";

string charmander=@"



                      _.-----..
                    ,'          `.
                  ,'          __  `.
                /|           __   \
                , |           / |.   .
                |,'          !_.'|   |
              ,'             '   |   |
            /              |`--'|   |
            |                `---'   |
            .   ,                   |                       ,*.
              ._     '           _'  |                    , ' \ `
          `.. `.`-...___,...-----    |       __,.        ,`'   L,|
          |, `- .`._        _,-,.'   .  __.-'-. /        .   ,    \
        -:..     `. `-..--_.,.<       `-      / `.        `-/ |   .
          `,         +++++'     `.              ,'         |   |  ',,
            `.      '            '            /          '    |'. |/
              `.   |              \       _,-'           |       ''
                `._'               \   ''\                .      |
                  |                '     \                `._  ,'
                  |                 '     \                 .'|
                  |                 .      \                | |
                  |                 |       L              ,' |
                  `                 |       |             /   '
                    \                |       |           ,'   /
                  ,' \               |  _.._ ,-..___,..-'    ,'
                /     .             .      `!             ,j'
                /       `.          /        .           .'/
              .          `.       /         |        _..'.'
                `.          7`'---'          |------' .'
              _,.`,_     _'                ,''-----''
          _,''    '       `.     .'      ,\
          -' /`.         _,'     | _  _  _.|
            '''--''''''''''''        `' '! |! /
                                    `'' '' -' ";



        string squirtle=@"
                      _,........__
                    ,-'            '`-.
                  ,'                   `-.
                ,'                        \
              ,'                           .
              .'\               ,...       `
            ._.'|             / |  `       \
            |   |            `-.'  ||       `.
            |   |            '-._,'||       | \
            .`.,'             `..,'.'       , |`-.
            l                       .'`.  _/  |   `.
            `-.._'-   ,          _ _'   -'' \  .     `
        `.'''''''''-.`-...,---------','         `. `...|
        .'        `'-..___      __,'\          \  \     \
        \_ .          |   `'''''''    `.           . \   \
          `.          |              `.          |  .     L
            `.        |`--...________.'.        j   |     |
              `._    .'      |          `.     .|   ,     |
                `--,\       .            `7''' |  ,      |
                    ` `      `            /     |  |      |    _,-'----.-.
                    \ `.     .          /      |  '      |  ,'           `.
                      \  v.__  .        '       .   \    /| /               \
                      \/    `''\''''''''`.       \   \  /.''                |
                        `        .        `._ ___,j.  `/ .-       ,---.      |
                        ,`-.      \         .''     `.  |/       |      `    |
                      /    `.     \       /         \ /         |     /    /
                      |       `-.   7-.._ .          |'          '         /
                      |          `./_    `|          |            .     _,'
                      `.           / `----|          |-............`---'
                        \          \      |          |
                      ,'          |     `.          |
                        7____,,..--'      /          |
                                          `---.__,--.'";

        string pikachu=@"
              ,___          .-;'
              `'-.`\_...._/`.`
            ,      \        /
        .-' ',    / ()   ()\
        `'._   \  /()    .  (|
            > .' ;,     -'-  /
          / <   |;,     __.;
          '-.'-.|  , \    , \
              `>.|;, \_)    \_)
              `-;     ,    /
                  \    /   <
                  '. <`'-,_)
                    '._)

        ";
//Console.WriteLine($"a)Bulbasur: {bulbasur} \n b)Charmander: {charmander} \n c)Squirtle: {squirtle} \n d)Pikachu: {pikachu}");


switch (tipo)
{
  case TiposDePj.agua:
    Console.WriteLine("\n Por haber elegido el tipo agua, se le adjudico el pokemon conocido como:  Squirtle");
    Console.WriteLine(squirtle);
Console.WriteLine("ahora te toca enfrentarte a guerreros, quizas mas fuerte que tu, suerte en esta aventura guerrero");
  break;

  case TiposDePj.fuego:
    Console.WriteLine("\n Por haber elegido el tipo fuego, se le adjudico el pokemon conocido como: Charmander");
    Console.WriteLine(charmander);
Console.WriteLine("ahora te toca enfrentarte a guerreros, quizas mas fuerte que tu, suerte en esta aventura guerrero");
  break;

  case TiposDePj.hoja:
    Console.WriteLine("\n Por haber elegido el tipo hoja, se le adjudico el pokemon conocido como: Bulbasaur");
    Console.WriteLine(bulbasur);
Console.WriteLine("ahora te toca enfrentarte a guerreros, quizas mas fuerte que tu, suerte en esta aventura guerrero");
  break;

  case TiposDePj.rayo:
    Console.WriteLine("\n Por haber elegido el tipo agua, se le adjudico el pokemon conocido como:  Pikachu");
    Console.WriteLine(pikachu);
Console.WriteLine("ahora te toca enfrentarte a guerreros, quizas mas fuerte que tu, suerte en esta aventura guerrero");  
  break;

}
    }

  }

}