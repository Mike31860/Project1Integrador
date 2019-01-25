using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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


        public void guardarArchivo1(String nombre)
        {
            

            StreamWriter escribir = new StreamWriter(nombre);


            escribir.Write("Nombre  Code  Edad  Country");
            escribir.WriteLine();
            for (int i = 0; i < Estudiantes.LongCount(); i++)
            {
                escribir.Write(Estudiantes[i].Name + " " + Estudiantes[i].Code + " " +
                Estudiantes[i].Edad + " " + Estudiantes[i].Carrera1 + " " + Estudiantes[i].semestre);
                escribir.WriteLine();

            }
            escribir.Close();

        }

        public List<Estudiante> abrirArchivo(String text)
        {
            
            StreamReader leer = new StreamReader(text);
            leer.ReadLine();
            String mensaje = leer.ReadLine();

            while (mensaje!=null)
            {
                String[] informacion = mensaje.Split(' ');
                String name = informacion[0];
                String code = informacion[1];
                int edad = int.Parse(informacion[2]);
                String carrera = informacion[3];
                int semestre = int.Parse(informacion[4]);


                Estudiante nuevo = new Estudiante(name, code, edad, carrera, semestre);
                
                Estudiantes.Add(nuevo);
                mensaje = leer.ReadLine();

            }

            return Estudiantes;

        }





    }
}
