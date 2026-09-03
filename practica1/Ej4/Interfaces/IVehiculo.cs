namespace practica1.Ej4
{
    public interface IVehiculo
    {
        public string Conducir()
        {
            return "";
        }
        
        public bool CargarCombustible(int cantidadCarga)
        {
            return true;
        }
        public int Id()
        {
            return -1;
        }
    }
}