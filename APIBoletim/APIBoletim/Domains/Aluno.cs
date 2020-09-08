using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBoletim.Domains
{
    public class Aluno
    {
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public string RA { get; set; }
        public int Idade { get; set; }
    }
}
