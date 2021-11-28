using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class GenerarLog
	{
        /// <summary>
        /// Genera un log de error
        /// </summary>
        /// <param name="errorMessage">Mensaje de error</param>
        /// <param name="pathFinal">Ruta donde se guardo el archivo</param>
        /// <returns>Devuelve true en caso de que se haya escrito, en caso de excepcion da false</returns>
        public bool ImprimirLog(string errorMessage, out string pathFinal)
        {
            bool imprimio;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error.log");
            try
            {
                Archivo archivo = new Archivo();
                archivo.Escribir($"{errorMessage}", path);
                imprimio = true;
            }
            catch (Exception)
            {
                imprimio = false;
            }

            pathFinal = path;

            return imprimio;
        }
    }
}
