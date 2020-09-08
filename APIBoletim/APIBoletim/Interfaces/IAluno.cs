using APIBoletim.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBoletim.Interfaces
{
    interface IAluno
    {
        Aluno Cadastrar(Aluno a);
        List<Aluno> LerTodos();
        Aluno BuscarPorId(int id);
        Aluno Alterar(Aluno a);
        Aluno Excluir(Aluno a);
    }
}
