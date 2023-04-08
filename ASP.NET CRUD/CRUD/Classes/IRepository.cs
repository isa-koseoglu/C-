using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EchoposCRUD.Classes
{
    public interface IRepository<TEntity>
    {
        Task<TEntity> Get(int? id);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> Add(TEntity entity);
        Task<IEnumerable<TEntity>> GetAll();
    }
}
