using ServiciosWeb.Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiciosWeb.WebApi.Controllers
{
    public class LibroController : ApiController
    {
        readonly LibreriaEntities BD = new LibreriaEntities();
        /// <summary>
        /// Permite consultar la información de todos los libros
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Libro> Get()
        {
            var listado = BD.Libro.ToList();
            return listado;
        }
        [HttpPost]
        public Libro Get(int ID)
        {
            var libro = BD.Libro.FirstOrDefault(x => x.Id_Libro == ID);
            return libro;
        }
    }
}
