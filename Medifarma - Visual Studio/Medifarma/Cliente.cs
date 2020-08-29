using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medifarma
{
    class Cliente
    {
        public int CodCli { get; set; }
        public string Nome { get; set; }
        public string Logi { get; set; }
        public string Senha { get; set; }
        public DateTime DataCad { get; set; }
        public Byte[] Foto { get; set; }
    }
}
