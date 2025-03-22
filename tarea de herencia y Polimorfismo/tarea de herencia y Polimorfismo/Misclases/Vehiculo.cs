using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_de_herencia_y_Polimorfismo.Misclases
{
    internal class Vehiculo
    {
        
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }

        
        protected int velocidad ;
        protected bool encendido = false;


        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
            this.velocidad = 100 ;
        }
        public virtual void frenar(int cuanto)
        {
            if (velocidad > 0)
            {
                velocidad -= cuanto; 
                if (velocidad < 0) velocidad = 0; // esto se coloco para evitar que la velocidad sea negativa
                Console.WriteLine("Vas a {0} Kms/hora", velocidad);
            }
            else
            {
                Console.WriteLine("El vehículo ya está detenido.");
            }
        }

        // Método público para consultar la velocidad actual
        public int ObtenerVelocidad()
        {
            return velocidad;
        }


        public void InformacionVehiculo()
        {
            Console.WriteLine("Color {0}:", this.Color);
            Console.WriteLine("Modelo {0}:", this.Modelo);
            Console.WriteLine("Año {0}", this.Year);
        }
        public virtual void acelerar(int cuanto)
        {
            velocidad += cuanto;
            Console.WriteLine("vas a {0} KMS / Hora", velocidad);
        }
        public virtual void encender ()
        {
            if (encendido) // si esta encendido
            {
                encendido = true;
                Console.WriteLine("El vehiculo esta encendido");
            }
            else
            {
                Console.WriteLine("El veculo ya esta encendido");
            }
        }
        public virtual void apagar()
        {
            if(encendido)
            { 
            encendido = false;
            Console.WriteLine("El vehiculo esta apagado");
            }
            else
            {
                Console.WriteLine("El vehiculo ya esta apagado");
            }
        }
        public virtual void  MostrarEstadoEncendido()
        {
            if (!encendido)
            {
                Console.WriteLine("El vehículo está encendido.");
            }
            else
            {
                Console.WriteLine("El vehículo está apagado.");
            }
        }

    }

}
