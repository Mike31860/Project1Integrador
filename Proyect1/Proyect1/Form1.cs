using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
          

            
         
          
        }







    }
}
