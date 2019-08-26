using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelatorioEmpresa.Domain;
namespace RelatorioEmpresa.ApplicationServices
{

    /*
     Essa Classe Funcionario-App tem que chamar o repositorio e ela
     possou mesma implementação de Insert, Read, Update e Delete
         
    */
    public class FuncionarioApp : IFuncionarioApp
    {

        /* Vamos injetar uma dependência */
        IFuncionarioRepository funcionarioRepository;

        public FuncionarioApp(IFuncionarioRepository funcRepository)
        {

            this.funcionarioRepository = funcRepository;
        }


      
        public List<FuncionarioRepository> Listar()
        {
            return funcionarioRepository.Listar();
        }

        public IEnumerable<FuncionarioRepository> ListarAndares()
        {
            return funcionarioRepository.ListarAndares();
        }

      

        List<FuncionarioRepository> IFuncionarioRepository.ListarAndares()
        {
            return funcionarioRepository.ListarAndares();
        }
    }
}
