using System;
using System.IO;

namespace Entidades
{
    public class Archivo : IArchivo<String>
    {
        /// <summary>
        /// Lee el archivo
        /// </summary>
        /// <param name="path">Ruta del archivo</param>
        /// <returns>El contenido del archivo</returns>
        public string Leer(string path)
        {
            string rtrn = "";
            try
            {
                using StreamReader sr = new StreamReader(path);
                while(!sr.EndOfStream)
                {
                    rtrn += $"{sr.ReadLine()}\n";
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            return rtrn;
        }
        /// <summary>
        /// Escribe en el archivo
        /// </summary>
        /// <param name="dato">Dato a agregar</param>
        /// <param name="path">Ruta del archivo</param>
        /// <param name="append">Si se desea sobreescribir el archivo o no</param>
        public void Escribir(string dato, string path)
        {
            try
            {
                using StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(dato);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
