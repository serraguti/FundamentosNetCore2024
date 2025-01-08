﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperFiles
    {
        //NECESITAMOS DOS METODOS: LEER Y ESCRIBIR
        //CON DICHOS METODOS DEBEMOS UTILIZAR ASYNC/AWAIT
        //CUANDO CREAMOS METODOS ASYNC/AWAIT PROPIOS, DEBEMOS 
        //UTILIZAR LA CLASE Task
        //NO SE UTILIZA void
        //SI ES UN void: Task
        //SI ES UN return: Task<ClaseReturn>
        public static async Task<string> ReadFileAsync(string path)
        {
            FileInfo file = new FileInfo(path);
            using (TextReader reader = file.OpenText())
            {
                string data = await reader.ReadToEndAsync();
                reader.Close();
                return data;
            }
        }

        public static async Task WriteFileAsync(string path, string data)
        {
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(data);
                await writer.FlushAsync();
                writer.Close();
            }
        }
    }
}
