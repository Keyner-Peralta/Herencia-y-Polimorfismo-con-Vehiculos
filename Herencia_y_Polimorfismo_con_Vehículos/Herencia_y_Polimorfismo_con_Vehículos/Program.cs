namespace Herencia_y_Polimorfismo_con_Vehículos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche Coche = new Coche();
            Avion Avion = new Avion();

            //Coche
            Coche.ArrancarMotor();
            Coche.Conducir();

            Coche.Acelerar();// Metodos de Coche
            Coche.Frenar();// Metodos de Coche

            Coche.PararMotor();


            //Avion
            Avion.ArrancarMotor();
            Avion.Conducir();

            Avion.Despegar();// Metodos de Avion
            Avion.Aterrizar();// Metodos de Avion

            Avion.PararMotor();
        }
    } 
    class Vehiculo
    {
        protected bool motor;
        public bool ArrancarMotor()
        {
            if(motor)
            {
                Console.WriteLine("El motor ya esta encendido");
                return true;
            }

            Console.WriteLine("El motor esta encedido");
            return motor = true;
        }

        public bool PararMotor()
        {
            if(!motor)
            {
                Console.WriteLine("El motor ya esta apagado");
                return false;
            }
            Console.WriteLine("El motor esta apagado");
            return motor = false;
        }

        public virtual void Conducir() => Console.WriteLine("Estas conduciendo un Vehiculo");
    }

    class Coche : Vehiculo
    {
        public void Acelerar()
        {
            if (!motor)
            {
                Console.WriteLine("El motor esta apagado");
                return;
            }

            Console.WriteLine("El Coche esta acelerando");
        }

        public void Frenar()
        {
            if (!motor)
            {
                Console.WriteLine("El motor esta apagado");
                return;
            }

            Console.WriteLine("El Coche esta frenando");
        }

        public override void Conducir() => Console.WriteLine("Estas conduciendo un Coche");
    }

    class Avion : Vehiculo
    {
        public void Despegar()
        {
            if (!motor)
            {
                Console.WriteLine("El motor esta apagado");
                return;
            }

            Console.WriteLine("Despegando");
        }
        public void Aterrizar()
        {
            if (!motor)
            {
                Console.WriteLine("El motor esta apagado");
                return;
            }

            Console.WriteLine("Aterrizando");
        }
        public override void Conducir() => Console.WriteLine("Estas conduciendo un Avion");
    }
}
