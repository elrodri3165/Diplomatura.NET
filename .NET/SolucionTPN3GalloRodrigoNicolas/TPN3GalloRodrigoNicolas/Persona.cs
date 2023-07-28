using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN3GalloRodrigoNicolas
{
    internal class Persona
    {
        private string nombre;
        private string email;
        private int sueldo;
        private string sexo;
        private float peso;
        private float altura;

        public Persona(string nombre,int sueldo,string sexo,float peso,float altura)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;

            CrearEmail();
        }

        private void CrearEmail()
        {
            this.email = this.nombre + "@microsoft.com";
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public int GetSueldo()
        {
            return this.sueldo;
        }

        public string GetSexo()
        {
            return this.sexo;
        }

        public float GetPeso()
        {
            return this.peso;
        }

        public float GetAltura()
        {
            return this.altura;
        }
    }
}
