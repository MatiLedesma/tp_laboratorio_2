using System;
using System.Text;

namespace Entidades
{
    /// <summary>
    /// Clase tecnologia que hereda de producto
    /// </summary>
    public class Tecnologia : Producto
    {
        #region Atributos
        private string especificaciones;
        private TipoArtefacto tipoArtefacto;
        #endregion
        #region Propiedades
        /// <summary>
        /// Propiedad Especificaciones, devuelve el valor del atributo especificaciones
        /// </summary>
        public string Especificaciones
        {

            get
            {
                return this.especificaciones;
            }
            set
            {
                this.especificaciones = value;
            }
        }
        /// <summary>
        /// Propiedad TipoArtef, devuelve el valor del atributo de tipoArtefacto
        /// </summary>
        public string TipoArtef
        {
            get
            {
                return this.tipoArtefacto.ToString();
            }
            set
            {
                this.tipoArtefacto = value == "Celular" ? TipoArtefacto.Celular : value == "Televisor" ? TipoArtefacto.Televisor :
                    value == "Computadora" ? TipoArtefacto.Computadora : TipoArtefacto.Monitor;
            }
        }
        #endregion
        #region Constructores
        /// <summary>
        /// Constructo parametrizado de Tecnologia
        /// </summary>
        /// <param name="id">Id del producto</param>
        /// <param name="precio">Precio del producto</param>
        /// <param name="nombre">Nombre del producto</param>
        /// <param name="especificaciones">Especificaiones del dispositivo</param>
        /// <param name="tipoArtefacto">Tipo de Artefacto</param>
        public Tecnologia(int id, float precio, string nombre, string especificaciones, TipoArtefacto tipoArtefacto)
            : base(precio, id, nombre)
        {
            this.especificaciones = especificaciones;
            this.tipoArtefacto = tipoArtefacto;
        }
        /// <summary>
        /// Constructor sin parametros, inicializa los valores en 0 y string vacío
        /// </summary>
        public Tecnologia() : this(0, 0, "", "", TipoArtefacto.Celular) { }
        #endregion
        #region Métodos
        /// <summary>
        /// Metodo mostrar, muestra los datos de la Tecnologia
        /// </summary>
        /// <returns>Devuelve un string con los datos de la Tecnologia</returns>
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.ToString()}\t\t\t{this.especificaciones}\t\t\t{this.tipoArtefacto}");
            return sb.ToString();
        }
        #endregion
        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga del operador ==, de ser los productos iguales y la especificacion entonces son los mismos
        /// </summary>
        /// <param name="a">Tecnologia a</param>
        /// <param name="b">Tecnologia b</param>
        /// <returns>Devuelve true or false en caso de que los productos sean iguales y las especificaciones sean iguales</returns>
        public static bool operator ==(Tecnologia a, Tecnologia b)
        {
            return (Producto)a == (Producto)b && a.Nombre == b.Nombre;
        }
        public static bool operator !=(Tecnologia a, Tecnologia b)
        {
            return !(a == b);
        }
        #endregion
        #region Polimorfismo
        /// <summary>
        /// Polimorfismo del metodo ToString()
        /// </summary>
        /// <returns>Devuelve el metodo Mostrar con los datos del objeto</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

    }
}
