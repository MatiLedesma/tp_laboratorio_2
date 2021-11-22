using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Stock <T> where T : class
    {
        #region Atributos
        private List<T> stock;
        private int cantidadStock;
        #endregion

        public List<T> Stock_a
        {
            get
            {
                return this.stock;
            }
            set
            {
                this.stock = value;
            }
        }

        #region Constructor/es
        /// <summary>
        /// Constructor parametrizado, incializa la lista, la cantidad de stock y le asigna la cantidad maxima de stock
        /// </summary>
        /// <param name="cantidadStock">cantidad total que se puede almacenar en stock</param>
        public Stock(int cantidadStock)
        {
            this.stock = new List<T>();
            this.cantidadStock = cantidadStock;
        }

        public Stock() : this(0)
        { }
        #endregion
        #region Métodos
        /// <summary>
        /// Metodo Mostrar, muestra los datos del objeto
        /// </summary>
        /// <returns>Devuelve el string generado con los datos del objeto</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            foreach (object p in this.stock)
            {
                sb.Append($"\n{p}");
            }
            return sb.ToString();
        }
        #endregion

        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="s">Clase Stock</param>
        /// <param name="p">Objeto</param>
        /// <returns>Devuelve true en caso de que los objetos sean iguales, falso en caso contrario</returns>
        public static bool operator ==(Stock<T> s, object p)
        {
            bool eq = false;
            foreach (object prod in s.stock)
            {
                if (prod == p)
                {
                    eq = true;
                }
            }
            return eq;
        }
        public static bool operator !=(Stock<T> s, object p)
        {
            return !(s == p);
        }
        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="s">Clase Stock</param>
        /// <param name="p">Objeto p</param>
        /// <returns>Añade un elemento al stock en caso de tener espacio, caso contrario se lanza una excepcion</returns>
        public static Stock<T> operator +(Stock<T> s, object p)
        {
            if (s.stock.Count < s.cantidadStock)
            {
                if (s != p)
                {
                    s.stock.Add((T)p);
                }
                else
                {
                    throw new Exception("Error: el elemento ya existe en el stock");
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
        /// <param name="p">Objeto p</param>
        /// <returns>Quita un elemento de la lista en caso de ser encontrado, caso contrario lanza una excepcion</returns>
        public static Stock<T> operator -(Stock<T> s, object p)
        {
            if (s == p)
            {
                s.stock.Remove((T)p);
            }
            else
            {
                throw new Exception($"Error: el objeto que desea eliminar no fue encontrado");
            }
            return s;
        }
    }
}
