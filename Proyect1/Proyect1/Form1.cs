using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyect1
{
    public partial class Form1 : Form
    {

        private UniversidadIcesi icesi2;



        public Form1()
        {
            icesi2 = new UniversidadIcesi();
          
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            String nombre = textName.Text;
            String code = textCodigo.Text;
            int edad = Int32.Parse(textEdad.Text);
            String carrera = comboBoxCarrera.Text;
            int semestre = Int32.Parse(comboBoxSemestre.Text);
            
            Estudiante estudiante = new Estudiante(nombre, code, edad, carrera, semestre);
            icesi2.guardarEstudiante(nombre, code, edad, carrera, semestre);
            lista.Items.Add(estudiante);

         



        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox index = (ListBox) sender;
            Estudiante encontrado = (Estudiante ) index.SelectedItem;
            textName.Text = encontrado.Name;
            textEdad.Text = encontrado.Edad+"";
            comboBoxCarrera.Text = encontrado.Carrera1;
            comboBoxSemestre.Text =  encontrado.semestre+"";
            textCodigo.Text = encontrado.Code;

          

            
         
          
        }

        private void guardarArchivo_Click(object sender, EventArgs e)
        {
            savefile.InitialDirectory = ".//Proyect1//Proyect1//Archivos";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                String nombre = savefile.FileName;

                StreamWriter escribir = new StreamWriter(nombre + ".txt");
                

                    escribir.Write("Nombre  Code  Edad  Country \n ");
                    escribir.WriteLine();
                    for (int i = 0; i < icesi2.Estudiantes.LongCount(); i++)
                    {
                        escribir.Write("\n" + icesi2.Estudiantes[i].Name + " " + icesi2.Estudiantes[i].Code + " " +
                            icesi2.Estudiantes[i].Edad+" "+ icesi2.Estudiantes[i].Carrera1+" "+icesi2.Estudiantes[i].semestre);
                        escribir.WriteLine();

                    }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Abrir(object sender, EventArgs e)
        {

        }
    }
}
