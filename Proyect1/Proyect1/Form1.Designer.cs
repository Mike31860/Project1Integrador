﻿namespace Proyect1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.comboBoxCarrera = new System.Windows.Forms.ComboBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guardarArchivo = new System.Windows.Forms.Button();
            this.savefile = new System.Windows.Forms.SaveFileDialog();
            this.comboBoxSemestre = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AbrirBoton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Carrera:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Còdigo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Semestre:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(150, 72);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(121, 20);
            this.textName.TabIndex = 6;
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(150, 99);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(121, 20);
            this.textEdad.TabIndex = 7;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(150, 156);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(121, 20);
            this.textCodigo.TabIndex = 9;
            // 
            // comboBoxCarrera
            // 
            this.comboBoxCarrera.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarrera.FormattingEnabled = true;
            this.comboBoxCarrera.Items.AddRange(new object[] {
            "IngenieriaSistemas",
            "Medicina",
            "IngenieriaTelemática",
            "IngenierìaIndustrial"});
            this.comboBoxCarrera.Location = new System.Drawing.Point(150, 125);
            this.comboBoxCarrera.Name = "comboBoxCarrera";
            this.comboBoxCarrera.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCarrera.TabIndex = 11;
            this.comboBoxCarrera.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarrera_SelectedIndexChanged);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(75, 244);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(80, 40);
            this.Guardar.TabIndex = 12;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Control De Entrada";
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(336, 92);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(280, 147);
            this.lista.TabIndex = 15;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(371, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Personal Ingresado";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // guardarArchivo
            // 
            this.guardarArchivo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guardarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guardarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarArchivo.Location = new System.Drawing.Point(109, 300);
            this.guardarArchivo.Name = "guardarArchivo";
            this.guardarArchivo.Size = new System.Drawing.Size(151, 40);
            this.guardarArchivo.TabIndex = 17;
            this.guardarArchivo.Text = "Guardar Archivo";
            this.guardarArchivo.UseVisualStyleBackColor = false;
            this.guardarArchivo.Click += new System.EventHandler(this.guardarArchivo_Click);
            // 
            // comboBoxSemestre
            // 
            this.comboBoxSemestre.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3"});
            this.comboBoxSemestre.FormattingEnabled = true;
            this.comboBoxSemestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxSemestre.Location = new System.Drawing.Point(150, 179);
            this.comboBoxSemestre.Name = "comboBoxSemestre";
            this.comboBoxSemestre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSemestre.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(333, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(283, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nombre  Código   Edad  Carrera  Semestre";
            // 
            // AbrirBoton
            // 
            this.AbrirBoton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AbrirBoton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AbrirBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbrirBoton.Location = new System.Drawing.Point(191, 244);
            this.AbrirBoton.Name = "AbrirBoton";
            this.AbrirBoton.Size = new System.Drawing.Size(120, 40);
            this.AbrirBoton.TabIndex = 20;
            this.AbrirBoton.Text = "Abrir Archivo";
            this.AbrirBoton.UseVisualStyleBackColor = false;
            this.AbrirBoton.Click += new System.EventHandler(this.AbrirBoton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 380);
            this.Controls.Add(this.AbrirBoton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxSemestre);
            this.Controls.Add(this.guardarArchivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.comboBoxCarrera);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.ComboBox comboBoxCarrera;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button guardarArchivo;
        private System.Windows.Forms.SaveFileDialog savefile;
        private System.Windows.Forms.ComboBox comboBoxSemestre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AbrirBoton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
