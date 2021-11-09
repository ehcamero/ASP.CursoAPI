using ASP.CursoAPI.Business.Entities;

namespace ASP.CursoAPI.Business.Repositories
{
    public interface IUsuarioRepository
    {
        void Adicionar(Usuario usuario);
        void Commit();
        Usuario ObterUsuario(string login);
    }
}
