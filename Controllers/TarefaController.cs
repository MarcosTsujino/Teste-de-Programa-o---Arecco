using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaTarefa.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgendaTarefa.Controllers
{
    public class TarefaController : Controller
    {
        private readonly Contexto _contexto;

        public TarefaController(Contexto contexto)
        {
            _contexto = contexto;  
        }

        public IActionResult Index()
        {
            return View(PegarDatas();
        }

        private List<DatasViewModel> PegarDatas()
        {
            DateTime dataAtual = DateTime.Now;
            DateTime dataLimite = DateTime.Now.AddDays(10);
            int qtdDias = 0;
            DatasViewModel data;
            List<DatasViewModel> listaDatas = new List<DatasViewModel>();

            while(dataAtual < dataLimite)
            {
                data = new DatasViewModel();
                data.Datas = dataAtual.ToShortDateString();
                data.Identificadores = "collapse" + dataAtual.ToShortDateString().Replace("/", "");
                listaDatas.Add(data);
                qtdDias = qtdDias + 1;
                dataAtual = dataAtual.AddDays(qtdDias);
            }

            return listaDatas;
        }
    }
}