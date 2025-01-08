using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }
        private string Path;

        public HelperMascotas(string path)
        {
            this.Mascotas = new List<Mascota>();
            this.Path = path;
        }

        //Convertir la colección a String
        private string ConvertirMascotasString()
        {
            //GARFIELD,GATO@PLUTO,PERRO
            string data = "";
            foreach (Mascota mascota in this.Mascotas)
            {
                //GARFIELD,GATO
                string temp = mascota.Nombre + "," + mascota.Raza;
                data += temp + "@";
            }
            data = data.TrimEnd('@');
            return data;
        }

        //Convertir el String del Read a colección mascotas
        private void ConvertirMascotasList(string data)
        {
            //GARFIELD,GATO@PLUTO,PERRO
            //LIMPIAMOS LA COLECCION ACTUAL
            this.Mascotas.Clear();
            //SEPARAMOS EL STRING POR CADA MASCOTA @
            string[] datosMascotas = data.Split("@");
            foreach (string stringMascota in datosMascotas)
            {
                //GARFIELD,GATO
                string[] propiedades = stringMascota.Split(",");
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }

        //NECESITAMOS LEER/ESCRIBIR MASCOTAS DE ESTA COLECCION
        public async Task WriteMascotasAsync()
        {
            //CONVERTIMOS LA COLECCION A STRING
            string data = this.ConvertirMascotasString();
            await HelperFiles.WriteFileAsync(this.Path, data);
        }

        public async Task ReadMascotasAsync()
        {
            //LEEMOS EL FICHERO
            string data = await HelperFiles.ReadFileAsync(this.Path);
            this.ConvertirMascotasList(data);
        }
    }
}
