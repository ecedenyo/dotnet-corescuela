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

        public TiposEscuela TipoEscuela { get; set; }

        // Implementación corta del Constructor haciendo uso de la 'Igualación por Tuplas'
        // que es una caraterística de Lengs. Funcionales
        public Escuela(string nombre, int año) => (Nombre, AñoDeCreación) = (nombre, año);

        // A fin de que al momento de imprimir el obj se impriman sus propiedades, se
        // sobreescribe el método ToString que comparten todos los objs en C#
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela} \nFundación: {AñoDeCreación}\nPaís: {Pais}, Ciudad: {Ciudad}";
        }
    }
}