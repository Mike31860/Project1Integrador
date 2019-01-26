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


        private List<Persona> personas;


        public UniversidadIcesi()
        {
            personas = new List<Persona>();


        }

        

        public void guardarArchivo(string name, string codigo, int edad, string Carrera, int semestre)
        {
           


        }

        internal List<Persona> Personas { get => personas; set => personas = value; }


        public void guardarEstudiante(string name, int edad, string ocupacion , string motivo, string fecha)

        {
            Persona nuevo = new Persona(name, edad, ocupacion, motivo, fecha);
            Boolean esta = personas.Contains(nuevo);
            if (!esta)
            {
                personas.Add(nuevo);

            }




        }


        public void guardarArchivo1(String nombre)
        {
            

            StreamWriter escribir = new StreamWriter(nombre);


            escribir.Write("Nombre  Code  Edad  Country");
            escribir.WriteLine();
            for (int i = 0; i < personas.LongCount(); i++)
            {
                escribir.Write(personas[i].Name + "-" +  personas[i].Edad + "-" +
                    personas[i].ocupacion + "-" + personas[i].motivo2+"-"+personas[i].fecha);
                escribir.WriteLine();

            }
            escribir.Close();

        }

        public List<Persona> abrirArchivo(String text)
        {
            
            StreamReader leer = new StreamReader(text);
            leer.ReadLine();
            String mensaje = leer.ReadLine();


            while (mensaje!=null)
            {
                String[] informacion = mensaje.Split('-');
                String name = informacion[0];
                int edad = int.Parse(informacion[1]);
                String ocupacion = informacion[2];
                string motivo = informacion[3];
                string fecha = informacion[4];


                Persona nuevo = new Persona(name, edad, ocupacion, motivo, fecha);
                
                personas.Add(nuevo);
                mensaje = leer.ReadLine();

            }

            return personas;

        }





    }
}
