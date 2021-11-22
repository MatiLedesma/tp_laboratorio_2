using System;
using System.Collections.Generic;
using System.Reflection;

namespace Entidades
{
    public class Generics<T>
    {
        List<T> lista;

        public Generics()
        {
            this.lista = new List<T>();
        }
        public static Generics<T> operator +(Generics<T> generics, T valor)
        {
            if (valor.GetType() == typeof(T))
                generics.lista.Add((T)valor);
            else
                throw new Exception($"Error: object<{valor.GetType()}> no es igual al object<{typeof(T)}> especificado");
            return generics;
        }

        public void MostrarLista()
        {
            foreach(T t in this.lista)
            {
                Console.WriteLine(t);
            }
        }
    }
}
