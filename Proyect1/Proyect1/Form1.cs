﻿using System;
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

            Bitmap imagen = new Bitmap(Application.StartupPath + @"\Imagenes\uno.jpeg");
                
            this.BackgroundImage = imagen;
          
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
            int edad = Int32.Parse(textEdad.Text);
            String ocupacion = textOcupacion.Text;
            string motivo = motivoVisitatext.Text;
            string ingreso = dateTimePicker1.Text;

            
            Persona estudiante = new Persona(nombre, edad, ocupacion, motivo, ingreso);
            icesi2.guardarEstudiante(nombre, edad, ocupacion, motivo, ingreso);
            lista.Items.Add(estudiante);
            dataGridView1.Rows.Add(nombre, edad, ocupacion, motivo, ingreso);
            







        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox index = (ListBox) sender;
            Persona encontrado = (Persona ) index.SelectedItem;
            textName.Text = encontrado.Name;
            textEdad.Text = encontrado.Edad+"";
            textOcupacion.Text = encontrado.ocupacion;
            motivoVisitatext.Text =  encontrado.motivo2;
            dateTimePicker1.Text = encontrado.fecha;

          

            
         
          
        }

        private void guardarArchivo_Click(object sender, EventArgs e)
        {
            savefile.InitialDirectory = ".//Proyect1//Proyect1//Archivos";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                String nombre = savefile.FileName+".txt";
                icesi2.guardarArchivo1(nombre);
              


            }


        }

        private void AbrirBoton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = ".//Proyect1//Proyect1//Archivos";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String nombre = openFileDialog1.FileName;
                List<Persona> listaRetornada=icesi2.abrirArchivo(nombre);

                lista.Items.Clear();


                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                for (int i=0; i<icesi2.Personas.Count;i++)
                {
                    lista.Items.Add(icesi2.Personas[i]);
                }

                for (int i=0; i< icesi2.Personas.Count; i++)
                {
             
                       dataGridView1.Rows.Add(icesi2.Personas[i].Name, icesi2.Personas[i].Edad, icesi2.Personas[i].ocupacion,
                           icesi2.Personas[i].motivo2, icesi2.Personas[i].fecha);
                }


            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
          
            


        }
    }
}
