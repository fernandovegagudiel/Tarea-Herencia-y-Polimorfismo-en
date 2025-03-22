using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_de_herencia_y_Polimorfismo.Misclases
{
    internal class Camión : Vehiculo
    {

        private int horasUsoMotor;
        private int cargaActual;
        private int desgastesdefrenos;

        public Camión(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            horasUsoMotor = 0;
            cargaActual = 0;
            desgastesdefrenos = 0;
        }
        public  void registrarHorasMotor(int horas)
        { if (horas > 0)
            {
                horasUsoMotor += horas;
                Console.WriteLine("La cantidad de horas de uso del motor es {0}", horas);
            }
        else
            {
                Console.WriteLine("No se puede registrar una cantidad negativa de horas ");
            }
        }

        public void cargar(int cuanto)
        {
            if (cuanto > 0)
            {

                cargaActual += cuanto;
                Console.WriteLine("la cantidad de la carga es {0}", cargaActual);
            }
            else
            {
                Console.WriteLine("No se puede cargar una cantidad negativa ");
            }
        }
        public void verificarFrenos()
        {
            if (desgastesdefrenos > 80)
            {
                Console.WriteLine("Los frenos estan desgastados");
            }
            else
            {
                Console.WriteLine("los frenos estan en buen estado");
            }
        }
        public override void frenar(int cuanto)
        {
            base.frenar(cuanto);
        }
        public override void MostrarEstadoEncendido()
        {
            base.MostrarEstadoEncendido(); // Lógica de la clase base
            Console.WriteLine("Esta es una función adicional en la clase derivada.");
        }

    }
}
