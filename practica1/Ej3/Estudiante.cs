namespace practica1.Ej3
{
    public class Estudiante : Persona
    {
        public string MostrarEdad()
        {
            string textoEdad = $"Mi edad es {this.edad} años.";
            Console.WriteLine(textoEdad);
            return textoEdad;
        }
        public Estudiante() : base() {}
        public Estudiante(int e, string n) : base(e, n) {}
        public override string Saludar()
        {
            return $"Hola, soy el estudiante {this.name}";
        }
        public string Estudiar()
        {
            return "Estoy estudiando.";
        }
    }
}