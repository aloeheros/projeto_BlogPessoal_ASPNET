
using BlogAPI.Src.Modelos;
using Microsoft.EntityFrameworkCore;
/// <summary>
/// <para>Resumo: Classe contexto, responsavel por carregar contexto e definir  DbSets </ para >
/// <para>Criado por: Generation</para>
/// <para>Versão: 1.0</para>
/// <para>Data: 17/07/2022</para>
/// </summary>
namespace BlogAPI.Src.Contextos
{
    public class BlogPessoalContexto : DbContext
    {
        #region Atributos
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tema> Temas { get; set; }
        public DbSet<Postagem> Postagens { get; set; }
        #endregion
        #region Construtores
        public BlogPessoalContexto(DbContextOptions<BlogPessoalContexto> opt) :
        base(opt)
        {
        }
        #endregion
    }
}