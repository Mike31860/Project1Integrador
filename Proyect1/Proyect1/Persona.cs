using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
    class Persona
    {
     
     


        private string name;

 

        private int edad;

        private string Ocupacion;

        private String motivo;

        private string entrada;

        public Persona(string name, int edad, string ocupacion, String motivo2, string fecha)
        {
            this.name = name;
          
            this.edad = edad;
            this.Ocupacion = ocupacion;
            this.motivo = motivo2;
            this.entrada = fecha;

        }

        public string Name { get => name; set => name = value; }
    
        public int Edad { get => edad; set => edad = value; }
        public string ocupacion { get =>    Ocupacion; set => Ocupacion = value; }
        public string motivo2 { get => motivo; set => motivo = value; }
        public string fecha { get => entrada; set => entrada = value; }


        override
        public String ToString()
        {
            return this.name + " " + "  " + this.edad + "  " + this.ocupacion + "  " + this.motivo+" "+this.entrada;
        }

    }
}
