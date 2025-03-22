using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_de_herencia_y_Polimorfismo.Misclases
{
    internal class Motocicleta : Vehiculo
    {

        private String marca;
        private string Estadocadena;
        private int totalGasolina;
        private int velocidadMaxima;

        public Motocicleta(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            marca = "Kawasaki";
            velocidadMaxima = 180;
            Estadocadena = "tensa";
            totalGasolina = 30;

        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto); // Llamamos a la lógica base (opcional si aplicable)

            if (velocidad + cuanto * 2 <= velocidadMaxima) // Incremento más rápido (2x)
            {
                velocidad += cuanto * 2; // Aumenta el doble de lo normal
                Console.WriteLine("La motocicleta está acelerando rápidamente. Su velocidad actual es de " + velocidad + " km/h.");
                totalGasolina--;
            }
            else
            {
                velocidad = velocidadMaxima; // Límite de velocidad
                Console.WriteLine("Has alcanzado la velocidad máxima de la motocicleta.");
            }
        }
        public string Marca()
        {
            return marca;

        }

        public override void apagar()//apagar la motocicleta
        {
            base.apagar();

        }
        public override void encender()//encender la motocicleta llamando la logica de vehiculo
        {
            base.encender();
        }
        public override void frenar(int cuanto)
        {
            base.frenar(cuanto);

        }
        public string EStadoCadena()//esto es para saber el estado de la cadena 
        {
            return Estadocadena;
        }
        public void informacion() //informacion de la motocicleta
        {
            base.InformacionVehiculo();
        }

        public override void MostrarEstadoEncendido()
        {
            if (!encendido)
            {
                Console.WriteLine("La Motocicleta está encendido.");
            }
            else
            {
                Console.WriteLine("La Motocicleta está apagado.");
            }

        }
    }
}
