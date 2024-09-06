using JovemProgamadorMVC.Models;

namespace JovemProgamadorMVC.Data.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        List<Aluno> BuscarAlunos();
        void InserirAluno(Aluno aluno);
        Aluno BuscarId(int id);
        void EditarAluno(Aluno aluno);
        void ExcluirAluno(Aluno aluno);
    }

}
