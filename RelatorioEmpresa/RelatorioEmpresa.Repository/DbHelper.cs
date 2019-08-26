using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
namespace RelatorioEmpresa.Repository
{
    public static class DbHelper
    {
        //String de conexao com banco de dados
        private const string stringDeConexao = @"Data Source=DESKTOP;Initial Catalog=HCOR_IRITEL;Integrated Security=True";


        //Retornar Conexão
        public static SqlConnection obterConexao()
        {
            return new SqlConnection(stringDeConexao);
        }


        //Método que retorna um Inteiro
        public static int Execute(string sql, object parametro)
        {
            using (var db = obterConexao())
            {
                return db.Execute(sql, parametro, commandType:CommandType.StoredProcedure);
            }


        }

        //Metodo que retorna uma lista uma instancia
        //Retorna lista e Interface IEnumerable
        public static List<T> Query<T>(string sql, object parametro)
        {
            using (var db = obterConexao())
            {
                return db.Query<T>(sql, parametro, commandType: CommandType.StoredProcedure).ToList();
            }

        }


        public static T QueryFirstOrDefault<T>(string sql, object parametro)
        {
            using(var db = obterConexao())
            {
                return db.QueryFirstOrDefault<T>(sql, parametro, commandType:CommandType.StoredProcedure);
            }


        }




    }
}
