using JovemProgamadorMVC.Data.Repositorio.Interfaces;
using JovemProgamadorMVC.Models;

namespace JovemProgamadorMVC.Data.Repositorio
{
    public class ProfessorRepositorio : IProfessorRepositorio
    {

        private readonly BancoContexto _bancoContexto;

        public ProfessorRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<Professor> BuscarProfessor()
        {
            return _bancoContexto.Professor.ToList();
        }

        public void InserirProfessor(Professor professor)
        {
            _bancoContexto.Professor.Add(professor);
            _bancoContexto.SaveChanges();
        }

        public Professor BuscarId(int id)
        {
            return _bancoContexto.Professor.FirstOrDefault(x => x.Id == id);
        }

        public void EditarProfessor(Professor professor)
        {
            _bancoContexto.Professor.Update(professor);
            _bancoContexto.SaveChanges();
        }

        public void ExcluirProfessor(Professor professor)
        {
            _bancoContexto.Professor.Remove(professor);
            _bancoContexto.SaveChanges();
        }

    }
}
