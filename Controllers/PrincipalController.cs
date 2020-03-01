using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using MVCPlantilla.Utilerias;
using System.Data;

namespace MvcPlantilla.Controllers
{
    public class PrincipalController : Controller
    {
        //
        // GET: /Principal/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registrar()
        {
            return View();
        }
        public ActionResult Modificar()
        {
            return View();
        }
        public ActionResult Eliminar()
        {
            return View();
        }
        public ActionResult EliminarNum()
        {
            return View();
        }
        public ActionResult Consultar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registrar(int idVideo, string titulo, int reproducciones, string url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@reproducciones", reproducciones));
            parametros.Add(new SqlParameter("@url", url));
            BaseHelper.ejecutarSentencia("INSERT INTO Video " + "VALUES (@idVideo, @titulo, @reproducciones, @url)", CommandType.Text, parametros);
            return View();
        }
        [HttpPost]
        public ActionResult Modificar(int idVideo, string titulo, int reproducciones, string url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@reproducciones", reproducciones));
            parametros.Add(new SqlParameter("@url", url));
            BaseHelper.ejecutarSentencia("UPDATE Video " + "SET titulo = @titulo, reproducciones = @reproducciones, url = @url " + "WHERE idVideo = idVideo " , CommandType.Text, parametros);
            return View();
        }
        [HttpPost]
        public ActionResult Eliminar(int idVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            BaseHelper.ejecutarSentencia("DELETE FROM Video " + "WHERE @idVideo = idVideo", CommandType.Text, parametros);
            return View();
        }
        [HttpPost]
        public ActionResult EliminarNum(int reproducciones)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@reproducciones", reproducciones));
            BaseHelper.ejecutarSentencia("DELETE FROM Video " + "WHERE @reproducciones = reproducciones", CommandType.Text, parametros);
            return View();
        }
    }
}
