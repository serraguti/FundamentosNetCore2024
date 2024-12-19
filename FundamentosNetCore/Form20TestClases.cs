﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace FundamentosNetCore
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Apellidos = "Navidad";
            persona.Edad = 25;
            persona.Genero =  TipoGenero.Femenino;

            this.lstClases.Items.Add("Indizada " + persona[0]);
            this.lstClases.Items.Add("Indizada " + persona[33]);
            persona.Nacionalidad = Paises.Andorra;
            
            persona.Domicilio.Calle = "Oficina principal de Correos";
            persona.Domicilio.Ciudad = "Napapiiri, Finlandia";
            persona.Domicilio.CodigoPostal = 96930;
            this.lstClases.Items.Add
                ("Dirección: "
                + persona.Domicilio.Calle
                + ", " + persona.Domicilio.Ciudad
                + ", " + persona.Domicilio.CodigoPostal);

            this.lstClases.Items.Add(persona.GetNombreCompleto(true));
            this.lstClases.Items.Add("Edad: " + persona.Edad);
            this.lstClases.Items.Add("Género: "
                + persona.Genero + ", Nacionalidad: "
                + persona.Nacionalidad);
        }
    }
}