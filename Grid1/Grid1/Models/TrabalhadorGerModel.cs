using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grid1.Models
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
}