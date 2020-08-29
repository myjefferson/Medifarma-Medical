using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medifarma
{
    class Consulta
    {
        public int Codigo { get; set; }
        public string NomePaciente { get; set; }
        public DateTime DataNasc { get; set; }
        public string Genero { get; set; }
        public string CPF { get; set; }
        public string Especialidade { get; set; }
        public string Medico { get; set; }
        public DateTime Data { get; set; }
        public string Hora { get; set; }
        public string Convenio { get; set; }
        public string Preco { get; set; }
    }
}
