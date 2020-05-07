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
            String eleccion;

            Console.WriteLine("[1]Almacenar:");

            Console.WriteLine("[2]Cargar:");

            eleccion = Console.ReadLine();

            switch (eleccion)
            {
                case "1":

                    Almacenar();

                    break;

                case "2":

                    Cargar();

                    break;
            }
        }

        static void Almacenar()
        {
            String nombre, apellido, edad;

            nombre = "Daniel";

            apellido = "Saavedra";

            edad = "21";

            Persona persona = new Persona(nombre, apellido, edad);

            IFormatter formateador = new BinaryFormatter();

            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileMode.Write, FileMode.None);

            formateador.Serialize(stream, persona);

            stream.Close();
        }

        static void Cargar()
        {
            BinaryFormatter formateador = new BinaryFormatter();

            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileMode.Write, FileMode.None);

            Persona persona = (Persona)formateador.Deserialize(stream);

            stream.Close();

        }
    }
}
