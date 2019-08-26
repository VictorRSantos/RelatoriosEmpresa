using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioEmpresa.Domain
{
    public interface IFuncionarioRepository
    {

       
        List<FuncionarioRepository> Listar();

        List<FuncionarioRepository> ListarAndares();




    }
}
