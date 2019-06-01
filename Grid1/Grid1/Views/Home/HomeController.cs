using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.UI;

namespace Grid1.Controllers
{
    public class HomeController : Controller
    {
        public class TrabalhadorGerModel
        {
            public int codigo { get; set; }
            public string nome { get; set; }
            public int empresa { get; set; }
            public string descricaoEmpresa { get; set; }
            public int registro { get; set; }
            public string descricaoCargo { get; set; }
        }

        public ActionResult Index()
        {
            TrabalhadorGerModel obj1 = new TrabalhadorGerModel()
            {
                codigo = 1,
                nome = "gabriel",
                empresa = 001,
                descricaoEmpresa = "datamace",
                registro = 1,
                descricaoCargo = "analista programador jr"
            };

            TrabalhadorGerModel obj2 = new TrabalhadorGerModel()
            {
                codigo = 2,
                nome = "lucas",
                empresa = 001,
                descricaoEmpresa = "datamace",
                registro = 2,
                descricaoCargo = "analista programador jr"
            };

            IList<TrabalhadorGerModel> list = new List<TrabalhadorGerModel>();
            list.Add(obj1);
            list.Add(obj2);

            JavaScriptSerializer oSerializer = new JavaScriptSerializer();
            string sJSON = oSerializer.Serialize(list);

            ViewBag.Data = sJSON;
            ViewBag.Type = "TrabalhadorGerModel";

            return View();
        }
    }
}