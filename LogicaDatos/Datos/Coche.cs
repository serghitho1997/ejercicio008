using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDatos.Datos
{
    public class Coche
    {
        public Coche()
        {

        }

        public Coche(long id, string nombre, int edad)
        {
            this.ID = id;
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public long ID
        {
            get;  set;
        }

        public string Nombre
        {
            get; set;
        }
        public int Edad
        {
            get;  set;
        }

        public override bool Equals(object obj)
        {
            return obj is Coche coche &&
                ID == coche.ID;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(ID);
    
           }
        public override string ToString()
        {
            return $"{ID} - {Nombre} - {Edad}";
        }

    }


}