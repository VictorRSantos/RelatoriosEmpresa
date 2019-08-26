using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RelatorioEmpresa.ApplicationServices;
using RelatorioEmpresa.Domain;
using RelatorioEmpresa.Repository;

namespace RelatorioEmpresa.UI.Web.Controllers
{
    public class FuncionarioController : Controller
    {
        IFuncionarioApp funcionarioApp;
        public FuncionarioController(IFuncionarioApp funcionarioAppObj)
        {
            this.funcionarioApp = funcionarioAppObj;
        }
        
        //
        // Lista de  Funcionarios
        //
        public ActionResult Index()
        {
            /*
             * Agora não precisa mais estanciar as classes
            var funcionarioRepositorio = new FuncionarioRepository();
            var funcionarioApp = new FuncionarioApp(funcionarioRepositorio);
            */
            var lista = funcionarioApp.Listar();

            //string dropDown = funcionarioApp.ListarAndares();

            ViewBag.CarregaDropDrown = new SelectList(DbHelper.Query<Funcionario>("FILTRO_ANDARES", null));

            return View(lista);
        }
    }
}