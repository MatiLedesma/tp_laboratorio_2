using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas }
        ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color) : this(marca, chasis, color, ETipo.CuatroPuertas) 
        { 
        }
        /// <summary>
        /// Asigna el tipo de puertas y reutiliza el constructor de 3 parametros 
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        public override ETamanio Tamanio 
        { 
            get 
            { 
                return ETamanio.Mediano; 
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio} TIPO : {this.tipo}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
