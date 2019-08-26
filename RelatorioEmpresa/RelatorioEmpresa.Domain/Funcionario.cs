using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioEmpresa.Domain
{
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Andar { get; set; }

        public string Transporte { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Fim { get; set; }



    }
}
