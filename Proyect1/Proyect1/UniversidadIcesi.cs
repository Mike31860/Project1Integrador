using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyect1
{
    class UniversidadIcesi
    {


        private List<Estudiante> estudiantes;


        public UniversidadIcesi()
        {
            estudiantes = new List<Estudiante>();


        }

        

        public void guardarArchivo(string name, string codigo, int edad, string Carrera, int semestre)
        {
           


        }

        internal List<Estudiante> Estudiantes { get => estudiantes; set => estudiantes = value; }


        public void guardarEstudiante(string name, string codigo, int edad, string Carrera, int semestre)

        {
            Estudiante nuevo = new Estudiante(name, codigo, edad, Carrera, semestre);
            Boolean esta = estudiantes.Contains(nuevo);
            if (!esta)
            {
                estudiantes.Add(nuevo);

            }




        }


    }
}
