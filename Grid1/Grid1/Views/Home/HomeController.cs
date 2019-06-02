using Grid1.Models;
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
        

        public class EmpresaGerModel
        {
            public int codigo { get; set; }
            public string nome { get; set; }
            public int numero { get; set; }
            public string rua { get; set; }
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

            IDictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("codigo", "Código");
            dic.Add("nome", "Nome");
            dic.Add("descricaoEmpresa", "Empresa");
            dic.Add("descricaoCargo", "Cargo");

            //ViewBag.Data = list;
            //ViewBag.Dict = dic;

            JavaScriptSerializer oSerializer = new JavaScriptSerializer();
            string dataJSON = oSerializer.Serialize(list);
            string dicJSON = oSerializer.Serialize(dic);

            ViewBag.Data = dataJSON;
            ViewBag.Dict = dicJSON;

            return View();
        }

        [System.Web.Services.WebMethod]
        public ActionResult Helper()
        {
            EmpresaGerModel obj1 = new EmpresaGerModel()
            {
                codigo = 1,
                nome = "legal",
                numero = 1000,
                rua = "Rua"
            };

            EmpresaGerModel obj2 = new EmpresaGerModel()
            {
                codigo = 2,
                nome = "bad",
                numero = 2000,
                rua = "RuaA"
            };


            IList<EmpresaGerModel> list = new List<EmpresaGerModel>();
            list.Add(obj1);
            list.Add(obj2);

            IDictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("codigo", "Código");
            dic.Add("nome", "Nome");
            dic.Add("numero", "Número");
            dic.Add("rua", "Rua");

            string[] array = new string[] { "codigo", "nome" };

            JavaScriptSerializer oSerializer = new JavaScriptSerializer();
            string dataJSON = oSerializer.Serialize(list);
            string dicJSON = oSerializer.Serialize(dic);
            string arrayJSON = oSerializer.Serialize(array);

            ViewBag.DataEmp = dataJSON;
            ViewBag.DictionaryEmp = dicJSON;
            ViewBag.ArrayEmp = arrayJSON;

            Index();
            return View("Index");
        }
    }
}