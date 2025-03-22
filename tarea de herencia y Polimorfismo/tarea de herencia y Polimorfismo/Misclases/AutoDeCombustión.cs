using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tarea_de_herencia_y_Polimorfismo.Misclases
{
    internal class AutoDeCombustión : Vehiculo
    {
        private int capacidadEntanque;
        private int cantidadCombustible;
        private int nivelAceite;
        
        public AutoDeCombustión(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            capacidadEntanque = 60;
            cantidadCombustible = 29;
            nivelAceite = 100;
             
            
        }

            public override void frenar(int cuanto)
            {
                base.frenar(cuanto); // Reutilizamos la lógica de la clase base

                if (velocidad > 0)
                {
                cantidadCombustible -= 1; // Reducir el combustible al frenar
                    if (cantidadCombustible < 0) cantidadCombustible = 0; // Evitar valores negativos
                    Console.WriteLine("Cantidad de combustible restante: {0}", cantidadCombustible);
                }
            }

        public int capacidadEntan()
        {
            return capacidadEntanque;
        }
        public int CantidadCombustible()
        {
            return cantidadCombustible;
        }
        public int NivelAceite()
        {
            return nivelAceite;
        }
    }
    }

