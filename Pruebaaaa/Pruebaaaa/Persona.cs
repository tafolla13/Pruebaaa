using System;
using System.Collections.Generic;
using System.Text;

namespace Pruebaaaa
{
    class Persona
    {
        private String nombre;
        private int sueldo, horas;
        public string Nombre { set; get; }
        public int Sueldo { set; get; }
        public int Horas { set; get; }
    
    public Persona (String nombre, int hora, int sueldo)
        {
            this.Nombre = nombre;
            this.Sueldo = sueldo;
            this.Horas = hora;
        }
    
    }

}
