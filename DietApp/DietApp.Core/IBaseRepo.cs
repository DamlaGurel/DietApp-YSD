using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Core
{
    public interface IBaseRepo<TEntity> where TEntity : BaseEntity
    {
        int Create(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);

        ICollection<TEntity> GetAll();
        TEntity GetByID(int id);
    }
}
