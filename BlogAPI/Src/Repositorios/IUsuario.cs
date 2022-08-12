
using BlogAPI.Src.Modelos;
using System.Threading.Tasks;
/// <summary>
/// <para>Resumo: Responsavel por representar ações de CRUD de usuario</para>
/// <para>Criado por: Generation</para>
/// <para>Versão: 1.0</para>
/// <para>Data: 29/04/2022</para>
/// </summary>
namespace BlogAPI.Src.Repositorios
{
    public interface IUsuario
    {
        Task<Usuario> PegarUsuarioPeloEmailAsync(string email);
        Task NovoUsuarioAsync(Usuario usuario);
    }
}
