using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
    class Estudiante
    {
        public static String INGENIERIASISTEMAS = "Ingenieria de sistemas";
        public static String INGENIERIATELEMATICA = "Ingenieria Telemática";
        public static String MEDICINA = "Medicina";
        public static String INGENIERIAINDUSTRIAL = "Ingenieria Industrial";
     


        private string name;

        private string code;

        private int edad;

        private string Carrera;

        private int Semestre;

        public Estudiante(string name,  string code, int edad, string carrera, int semestre)
        {
            this.name = name;
            this.code = code;
            this.edad = edad;
            this.Carrera = carrera;
            this.Semestre = semestre;
        }

        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Carrera1 { get => Carrera; set => Carrera = value; }
        public int semestre { get => Semestre; set => Semestre = value; }


        override
        public String ToString()
        {
            return this.name + " " + this.code + "  " + this.edad + "  " + this.Carrera + "  " + this.Semestre;
        }

    }
}
