using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace tarea_de_herencia_y_Polimorfismo.Misclases
{
    internal class CarroElectrico : Vehiculo
    {
        private int ciclosCarga;
        private int tiempoDeCarga;
        private int cargaBateria;

        public CarroElectrico(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            cargaBateria = 50; // Carga inicial de 50%
            ciclosCarga = 0;
            tiempoDeCarga = 0; // Tiempo inicial de carga
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto); // Llamar al método base
            if (cargaBateria > 0)
            {
                cargaBateria--;
                Console.WriteLine("La batería se ha reducido en 1 unidad.");
            }
            else
            {
                Console.WriteLine("La batería está completamente descargada.");
            }
        }

        public int obtieneTiempoCarga()
        {
            tiempoDeCarga += 2; // Incrementar tiempo de carga 2 unidades 
            return tiempoDeCarga;
        }

        public int NivelBateria()
        {
            return cargaBateria; // Retornar nivel actual de batería
        }

        public int ciclosDecarga()
        {
            ciclosCarga++; // Incrementar ciclos de carga
            return ciclosCarga;
        }

        public void cargarBateria()
        {
            if (cargaBateria < 100) // Evitar exceder el 100%
            {
                cargaBateria++;
                Console.WriteLine("La batería se está cargando. nivel de carga actual {0}%", cargaBateria++);
            }
            else
            {
                Console.WriteLine("La batería ya está completamente cargada.");
            }
        }

        public  void Encender()
        {
            if (!encendido) // Si no está encendido
            {
                encendido = true;
                Console.WriteLine("El vehículo está encendido.");
            }
            else
            {
                Console.WriteLine("El vehículo ya está encendido.");
            }
        }

        public override void apagar()
        {
            base.apagar();
        }
        public override void encender()
        {
            base.encender();
        }
        // Opción 1: Método para mostrar el estado
        public override void MostrarEstadoEncendido()//esto es para mostrar el estado del carro apagado o encendido
        {
            base.MostrarEstadoEncendido();

        }

       
       
    }
}

