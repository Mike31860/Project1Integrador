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
                icesi2.guardarArchivo1(nombre);
              


            }
        }

        private void AbrirBoton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = ".//Proyect1//Proyect1//Archivos";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String nombre = openFileDialog1.FileName;
                List<Estudiante> listaRetornada=icesi2.abrirArchivo(nombre);
                for (int i=0; i<icesi2.Estudiantes.Count;i++)
                {
                    lista.Items.Add(icesi2.Estudiantes[i].ToString());
                }



            }

        }
    }
}
