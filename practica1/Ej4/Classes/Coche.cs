namespace practica1.Ej4;

public class Coche : IVehiculo
{
    private int _combustible {get; set;}
    private static int _lastId = 1000;
    private int _id {get; set;}
    public Coche(int initialCombustible)
    {
        this._combustible = initialCombustible;
        _lastId++;
        this._id = _lastId;
    }
    public bool CargarCombustible(int cantidadCarga)
    {
        if (cantidadCarga>0)
        {
            this._combustible += cantidadCarga;
            return true;
        }
        else
        {
            return false;
        }
    }
    public string Conducir()
    {
        if (this._combustible > 0)
        {
            return $"El coche #{this._id} está siendo manejado";
        }
        else
        {
            return $"El coche #{this._id} no tiene combustible";
        }
    }
    public int Id()
    {
        return this._id;
    }
}