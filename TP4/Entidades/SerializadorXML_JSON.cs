﻿using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializadorXML_JSON<T> : IArchivo<T> where T : class
    {
        #region Atributos
        private IArchivo<T>.ETipoArchivo eTipoArchivo;
        #endregion
        #region Constructores
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="eTipoArchivo">Especifica el tipo de extensión del archivo</param>
        public SerializadorXML_JSON(IArchivo<T>.ETipoArchivo eTipoArchivo)
        {
            this.eTipoArchivo = eTipoArchivo;
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Escribe los datos en un archivo .xml o .json
        /// </summary>
        /// <param name="dato">El objeto a guardar</param>
        /// <param name="path">La dirección del archivo</param>
        /// <param name="append">Si se desea hacer sobreescritura del archivo o no</param>
        public void Escribir(T dato, string path)
        {
            try
            {
                if (this.eTipoArchivo == IArchivo<T>.ETipoArchivo.XML)
                {
                    if (Path.GetExtension(path) == ".xml")
                    {
                        using XmlTextWriter xmlTW = new XmlTextWriter(path, Encoding.UTF8);
                        xmlTW.Formatting = Formatting.Indented;
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                        xmlSerializer.Serialize(xmlTW, dato);
                    }
                    else
                    {
                        throw new Exception("Extensión no válida: no es una extensión .xml");
                    }
                }
                else
                {
                    if (Path.GetExtension(path) == ".json")
                    {
                        Archivo archivo = new Archivo();
                        archivo.Escribir(JsonSerializer.Serialize(dato, typeof(T)), path);
                    }
                    else
                    {
                        throw new Exception("Extensión no válida: no es una extensión .json");
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception($"{e.Message}\n{e.StackTrace}");
            }
        }
        /// <summary>
        /// Lee el archivo .xml o .json
        /// </summary>
        /// <param name="path">Ruta del archivo a leer</param>
        /// <returns>El objeto que se encuentra en el archivo</returns>
        public T Leer(string path)
        {
            try
            { 
                if (this.eTipoArchivo == IArchivo<T>.ETipoArchivo.XML)
                {
                    if (Path.GetExtension(path) == ".xml")
                    {
                        XmlTextReader xmlTR = new XmlTextReader(path);
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                        return (T)xmlSerializer.Deserialize(xmlTR);
                    }
                    else
                    {
                        throw new Exception("Extensión no válida: no es una extensión .xml");
                    }
                }
                else
                {
                    if (Path.GetExtension(path) == ".json")
                    {
                        Archivo archivo = new Archivo();
                        return JsonSerializer.Deserialize<T>(archivo.Leer(path));
                    }
                    else
                    {
                        throw new Exception("Extensión no válida: no es una extensión .json");
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        #endregion
    }
}
