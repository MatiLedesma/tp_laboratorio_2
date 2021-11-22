using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class sStock
    {
        #region Atributos
        private List<Producto> producto;
        private int cantidadStock;
        #endregion

        public List<Producto> Productos
        {
            get
            {
                return this.producto;
            }
            set
            {
                this.producto = value;
            }
        }

        #region Constructores
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public sStock() : this(0)
        {
        }
        /// <summary>
        /// Constructor parametrizado, establece la cantidad maxima de stock que se admite e incializa la lista 
        /// y la cantidad de stock actual
        /// </summary>
        /// <param name="cantidadStock">cantidad maxima de sotck permitida</param>
        public sStock(int cantidadStock)
        {
            producto = new List<Producto>();
            this.cantidadStock = cantidadStock;
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Metodo mostrar, muestra la lista de los productos
        /// </summary>
        /// <returns>Devuelve un string con la lista de los productos</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto p in this.producto)
            {
                sb.Append($"\n{p}");
            }
            return sb.ToString();
        }
        #endregion
        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="s">Clase Stock</param>
        /// <param name="p">Clase Producto</param>
        /// <returns>Devuelve true en caso de que los productos sean iguales, falso en caso contrario</returns>
        public static bool operator ==(sStock s, Producto p)
        {
            bool eq = false;
            foreach(Producto prod in s.producto)
            {
                if (prod == p)
                {
                    eq = true;
                }
            }
            return eq;
        }       
        public static bool operator !=(sStock s, Producto p)
        {
            return !(s == p);
        }
        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="s">Clase Stock</param>
        /// <param name="p">Clase Producto</param>
        /// <returns>Añade un producto al stock en caso de tener espacio, caso contrario se lanza una excepcion</returns>
        public static sStock operator +(sStock s, Producto p)
        {
            if (s.Productos.Count < s.cantidadStock)
            {
                if (s != p)
                {
                    s.producto.Add(p);
                }
            }
            else
            {
                throw new Exception("Error: no hay mas espacio disponible");
            }
            return s;
        }
        /// <summary>
        /// Sobrecarga del operador -
        /// </summary>
        /// <param name="s">Clase Stock</param>
        /// <param name="p">Clase Producto</param>
        /// <returns>Quita un elemento de la lista en caso de ser encontrado, caso contrario lanza una excepcion</returns>
        public static sStock operator -(sStock s, Producto p)
        {
            if (s == p)
            {
                s.producto.Remove(p);
            }
            else
            {
                throw new Exception("Error: el producto que desea eliminar no fue encontrado");
            }
            return s;
        }
        #endregion
    }
}
