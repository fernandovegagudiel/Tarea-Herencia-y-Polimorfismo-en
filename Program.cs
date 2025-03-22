
using tarea_de_herencia_y_Polimorfismo.Misclases;


class Program
{
    static void Main(string[] args)
    {
        Vehiculo miCarrito = new Vehiculo(2026, "Azul", "Alfa Romeo");
        Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");
       

        Console.WriteLine("AUTO ELECTRICO");
        CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");
        miBYD.InformacionVehiculo();
        Console.WriteLine("El nivel de Bateria es: {0}", miBYD.NivelBateria());
        Console.WriteLine("El tiempo restante es: {0} Ahoras", miBYD.obtieneTiempoCarga());
        Console.WriteLine("El Ciclo de la CArga es  {0} veces", miBYD.ciclosDecarga());
        miBYD.MostrarEstadoEncendido();
        miBYD.cargarBateria();
        Console.WriteLine("\n");

        //datos de el AUTO DE COMBUSTION
        Console.WriteLine("AUTO DE COMBUSTION");
        AutoDeCombustión autocombus = new AutoDeCombustión(2022, "Gris", "Chevrolet");
        autocombus.InformacionVehiculo();
        autocombus.capacidadEntan();
        autocombus.MostrarEstadoEncendido();
        Console.WriteLine("cantidad de combustible : {0}", autocombus.CantidadCombustible());
        Console.WriteLine("La capacidad que posee el tanque es de : {0}", autocombus.capacidadEntan());
        autocombus.frenar(10);

        //DATOS DE MOTOCICLETA 
        Console.WriteLine("\n");
        Console.WriteLine("MOTOCICLETA");
        Motocicleta moto = new Motocicleta(2023, "Azul", "Ninja H2R");
        moto.InformacionVehiculo();
        moto.MostrarEstadoEncendido();
        Console.WriteLine("La marca de la motocicleta es: " + moto.Marca());
        moto.acelerar(2);
        moto.frenar(5);
        
        Console.WriteLine("\n");

        //DATOS DE CAMION
        Console.WriteLine("CAMION");
        Camión camion = new Camión(2022, "Blanco", "gama FH Volvo");
        camion.InformacionVehiculo();
        camion.cargar(12);
        camion.verificarFrenos();
        camion.registrarHorasMotor(12);
        camion.frenar(2);
    }
}
   



 
        