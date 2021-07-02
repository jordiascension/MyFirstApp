using System;

namespace MyFirstApp.Interfaces
{
    //Interface Segregation Principle
    public class Avion : IVehiculo, ICloneable
    {
        public void Acelerar(int kmh)
        {
            Console.WriteLine("Acelerando Vehículo");
        }

        public void Aterrizar()
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public void Despegar()
        {
            throw new NotImplementedException();
        }

        public void Frenar()
        {
            throw new NotImplementedException();
        }

        public void Girar(int angulos)
        {
            throw new NotImplementedException();
        }
    }
}
