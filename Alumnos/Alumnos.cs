using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Alumnos
{
    class Alumnos
    {
        ///<summary>
        ///Se crea un arraylist para meter los alumnos..
        ///</summary>
        
        private ArrayList listaAlumnos = new ArrayList();

        public ArrayList ListaAlumnos 
        {
            get { return listaAlumnos; }
        }

        ///<summary>
        ///Metodo para agregar los alumnos en el arraylist..
        ///</summary>
        ///<param name="Alum">Alumno que se le pasa</param>
        public void agregarAlumno(Alumno Alum)
        {
            listaAlumnos.Add(Alum);
        }
        ///<summary>
        ///metodo para sacar la media de los alumnos...
        ///</summary>
        ///<returns>Devuelve la media de los alumnos </returns>

        public double medianotas()
        {
            int acumulador = 0;
            double medialumnos = 0;

            foreach (Alumno alum in listaAlumnos)
            {
                acumulador = acumulador + alum.Nota;
            }

            if (listaAlumnos.Count == 0)
            {
                medialumnos = 0;
            }
            else
            {
                medialumnos = medialumnos / listaAlumnos.Count;
            }

            return acumulador;
        }

    }

}
