using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    /// <summary>
    /// Creamos la clase.
    /// </summary>
    class Alumno
    {
        /// <summary>
        /// Creamos el campo nombre.
        /// </summary>
        private string nombre;

        /// <summary>
        /// Creamos el campo nota.
        /// </summary>
        private int nota;

        /// <summary>
        /// Creamos la propiedad nombre, guarda el miembro nombre.
        /// </summary>
        /// <value>Devuelve el campo nombre</value>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Creamos la propiedad nota que contiene la nota.. Verifica los datos.
        /// </summary>
        /// <value>Devuelve el valor de la nota</value>
        public int Nota
        {
            get { return nota; }
            set
            {
                if (value >= 0 && value <= 10)
                    nota = value;
            }
        }

        /// <summary>
        /// Metodo que calcula si la nota del alumno es aprobada(superior a 5)..
        /// </summary>
        public Boolean Aprobado
        {
            get
            {
                if (nota >= 5)
                    return true;
                else
                    return false;
            }
        }
    }
}
