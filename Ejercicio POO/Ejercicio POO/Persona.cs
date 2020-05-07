using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio_POO
{
    [Serializable]
    class Persona
    {
        private String nombre;

        private String apellido;

        private String edad;

        public Persona(String nombre, String apellido, String edad)
        {
            this.nombre = nombre;

            this.apellido = apellido;

            this.edad = edad;
        }
    }
}
