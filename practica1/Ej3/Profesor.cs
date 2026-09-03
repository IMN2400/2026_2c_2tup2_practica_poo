namespace practica1.Ej3
{
    public class Profesor : Persona
    {
        public Profesor() : base() {}
        public Profesor(int e, string n) : base(e, n) {}
        public override string Saludar()
        {
            return $"Hola, soy el profesor {this.name}";
        }
        public string Explicar()
        {
            return "Estoy explicando.";
        }
    }
}