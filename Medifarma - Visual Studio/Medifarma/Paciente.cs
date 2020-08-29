using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medifarma
{
    class Paciente
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }
        public string Genero { get; set; }
        public string Convenio { get; set; }
        public string Descricao { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
    }
}
