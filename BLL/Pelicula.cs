using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    class Pelicula
    {
        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Ano { get; set; }
        public int Calificacion { get; set; }
        public int IMDB { get; set; }
        public int CategoriaId { get; set; }

        public Pelicula()
        {
            this.PeliculaId = 0;
            this.Titulo = "";
            this.Descripcion = "";
            this.Ano = 0;
            this.Calificacion = 0;
            this.IMDB = 0;
            this.CategoriaId = 0;
        }
        public Pelicula(int pPeliculaId, string pTitulo, string pDescripcion,int pAno,int pCalificacion,int pIMDB,int pCategoriaId)
        {
            PeliculaId = pPeliculaId;
            Titulo = pTitulo;
            Descripcion = pDescripcion;
            Ano = pAno;
            Calificacion = pCalificacion;
            IMDB = pIMDB;
            CategoriaId = pCategoriaId;
        }
        public bool Insertar()
        {
            bool retorno = false;

            ConexionDB conexion = new ConexionDB();

            conexion.Ejecutar(string.Format("Insert into(Titulo,Descripcion,Ano,Calificacion,IMDB,CategoriaID)",Titulo,Descripcion,Ano,Calificacion,IMDB,CategoriaId));

            return retorno;
        }
    }
}
