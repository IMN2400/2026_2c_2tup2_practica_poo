namespace practica1.Ej3
{
    public abstract class Persona
    {
        protected int edad {get; set;}
        protected string name {get; set;}
        public Persona ()
        {
            this.name = "Anónimo";
            this.edad = -1;
        }
        public Persona(int pEdad, string pName)
        {
            this.name = pName;
            this.edad = pEdad;
        }
        public virtual string Saludar()
        {
            return "Hola!";
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
    }
}