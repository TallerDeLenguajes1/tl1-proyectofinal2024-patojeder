namespace caracteristicasJugador
{

    public class Datos{
        private string nombre;
        private string apodo;
        private DateTime fechaNac;
        private int edad; 
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public  int Edad { get => edad; set => edad = value; } 

        public Datos(string nombre, string apodo, DateTime fechaNac, int edad){
            this.edad=edad;
            this.nombre=nombre;
            this.fechaNac=fechaNac;
            this.apodo=apodo;

        }
        public void NuevoJugador(){

        }

}

}

