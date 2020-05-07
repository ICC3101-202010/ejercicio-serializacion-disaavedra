using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Ejercicio_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }

        public void Almacenar()
        {
            String nombre, apellido, edad;

            nombre = "Daniel";

            apellido = "Saavedra";

            edad = "21";

            Persona persona = new Persona(nombre, apellido, edad);

            BinaryFormatter formateador = new BinaryFormatter();

            Stream stream = new FileStream("Persona.per", FileMode.Create, FileMode.Write, FileMode.None);

            formateador.Serialize(stream, persona);

            stream.Close();
        }

        public void Cargar()
        {
            BinaryFormatter formateador = new BinaryFormatter();

            Stream stream = new FileStream("Persona.per", FileMode.Create, FileMode.Write, FileMode.None);

        }
    }
}
