using back_usuarios_tg.DAL.Models;
using MongoDB.Driver;

namespace back_usuarios_tg.DAL.DAO
{
    public interface IMongoContext
    {
        IMongoCollection<Usuario> CollectionUsuario { get; }
    }
}
