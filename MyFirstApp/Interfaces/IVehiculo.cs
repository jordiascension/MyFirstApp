namespace MyFirstApp.Interfaces
{
    interface IVehiculo
    {
        void Acelerar(int kmh);
        void Frenar();
        void Girar(int angulos);
        void Despegar();
        void Aterrizar();
    }
}
