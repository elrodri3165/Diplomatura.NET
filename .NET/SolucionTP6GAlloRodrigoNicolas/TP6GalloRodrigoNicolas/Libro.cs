using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace TP6GalloRodrigoNicolas
{
    internal class Libro
    {
        private string Nombre;
        private string Autor; 
        private string Genero;
        private int Paginas;
        private string Importado;
        private float Precio;

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public void SetAutor(string Autor)
        {
            this.Autor = Autor;
        }

        public void SetGenero(string Genero) {
            this.Genero = Genero;    
        }

        public void SetPaginas(int Paginas)
        {
            this.Paginas = Paginas;
        }

        public void SetImportado(bool Impor)
        {
            if (Impor == true)
            {
                this.Importado = "SI";
            }
            else
            {
                this.Importado = "NO";
            }
        }

        public void SetPrecio(float Precio)
        {
            this.Precio = Precio;
        }

        public string GetLibroCompleto()
        {
            string libro = 
                this.Nombre + 
                " - " + 
                this.Autor + 
                " - " + 
                this.Genero + 
                " - Páginas: " +
                this.Paginas + 
                " - Precio: " + 
                this.Precio + 
                " - Importado: " + 
                this.Importado;

            return libro;
        }

    }
}
