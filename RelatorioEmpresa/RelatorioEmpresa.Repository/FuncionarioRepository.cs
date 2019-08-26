using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelatorioEmpresa.Domain;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace RelatorioEmpresa.Repository
{   

    public class Funcionario : IFuncionarioRepository
    {
      
              


        public List<Funcionario> Listar()
        {

            return DbHelper.Query<Funcionario>("RELATORIO_FILTRO", null);

            //return funcionarios.ToList().OrderBy(m => m.Nome).ToList();

        }

        public IEnumerable<Funcionario> ListarAndares()
        {
            return DbHelper.Query<Funcionario>("FILTRO_ANDARES", null);
           
        }

        public Funcionario ObterporId(int Id)
        {
            //var func = funcionarios.Where(m => m.Id == Id).FirstOrDefault();
            return DbHelper.QueryFirstOrDefault<Funcionario>("ClientePorId", new { id = Id });
            //return func;
        }

        public Funcionario ObterporId(string Id)
        {
            throw new NotImplementedException();
        }

        List<FuncionarioRepository> IFuncionarioRepository.Listar()
        {
            return DbHelper.Query<FuncionarioRepository>("FILTRO_ANDARES", null);

        }

        List<Domain.FuncionarioRepository> IFuncionarioRepository.ListarAndares()
        {
            return DbHelper.Query<Domain.FuncionarioRepository>("FILTRO_ANDARES", null);


        }

       
    }
}
