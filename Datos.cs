namespace caracteristicasJugador
{

    public class Datos{
        private TiposDePj tipo;
        private string nombre;
        private string apodo;
        private DateTime fechaNac;
        private int edad;
        private DateTime fechaPartida; 
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public  int Edad { get => edad; set => edad = value; }
        public TiposDePj Tipo { get => tipo; set => tipo = value; }
        public DateTime FechaPartida { get => fechaPartida; set => fechaPartida = value; }

        public Datos(){

        }

        public Datos(string nombre, string apodo, int edad, DateTime fechaNac, TiposDePj tipo){

                this.tipo=tipo;
                this.edad=edad;
                this.nombre=nombre;
                this.apodo=apodo;
                this.fechaNac=fechaNac;
                FechaPartida=DateTime.Today;
        }

}

}

