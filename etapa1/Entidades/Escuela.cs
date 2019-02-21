namespace CorEscuela.Entidades
{
    class Escuela
    {
        string nombre;

        // Encapsulando el atributo nombre como Propiedad
        public string Nombre
        {
            get { return "Copia: " + nombre; }
            set { nombre = value.ToUpper(); }
        }

        // Método corto de encapsulamiento 
        public int AñoDeCreación { get; set; }

        // 'prop' es la forma corta que brinda VSCode para crear una Propiedad
        public string Pais { get; set; }

        public string Ciudad { get; set; }

        /*public Escuela(string nombre, int año)
        {
            // El uso de 'this' es únicamente para diferenciar entre nombs. de vars
            this.nombre = nombre;
            AñoDeCreación = año;
        }*/

        // Implementación corta del Constructor haciendo uso de la 'Igualación por Tuplas'
        // que es una caraterística de Lengs. Funcionales
        public Escuela(string nombre, int año) => (Nombre, AñoDeCreación) = (nombre, año);
    }
}