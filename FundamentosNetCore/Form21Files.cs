﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProyectoClases.Helpers;

namespace FundamentosNetCore
{
    public partial class Form21Files : Form
    {
        private string Path { get; set; }
        private HelperFiles helper;

        public Form21Files()
        {
            InitializeComponent();
            
            //CUANDO HABLAMOS DE RUTAS DE FICHEROS, CON CARACTERES 
            //ESPECIALES: \ TENEMOS DOS POSIBILIDADES
            //C:\carpeta\file1.txt
            //1) UTILIZAR DOBLE CONTRABARRA
            this.Path = "C:\\carpeta\\file1.txt";
            //2) INDICAR QUE EL STRING SERA LITERAL: @
            this.Path = @"C:\carpeta\file1.txt";
            this.Path = "file1.txt";
        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
            this.txtNombre.SelectAll();
            this.txtNombre.Focus();
        }

        public string GetNombresListBox()
        {
            string data = "";
            foreach (string name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.Trim(',');
            return data;
        }

        private async void btnWriteFile_Click(object sender, EventArgs e)
        {
            string data = this.GetNombresListBox();
            await HelperFiles.WriteFileAsync(this.Path, data);
            MessageBox.Show("Datos guardados");
        }

        private async void btnReadFile_Click(object sender, EventArgs e)
        {
            string data = await HelperFiles.ReadFileAsync(this.Path);
            this.RellenarListBox(data);
            this.txtContenido.Text = data;
        }

        public void RellenarListBox(string nombres)
        {
            string[] data = nombres.Split(",");
            this.lstNombres.Items.Clear();
            foreach (string name in data)
            {
                this.lstNombres.Items.Add(name);
            }
        }
    }
}
