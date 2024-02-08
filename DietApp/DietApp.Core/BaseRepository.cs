using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Core
{
    public class BaseRepository<TEntity> : IBaseRepo<TEntity> where TEntity : BaseEntity
    {
        DbContext _context;
        public BaseRepository(DbContext db)
        {
            _context = db;
        }
        public int Create(TEntity entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
            return entity.ID;
        }

        public int Delete(TEntity entity)
        {
            _context.Remove(entity);
            return _context.SaveChanges();
        }

        public ICollection<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetByID(int id)
        {
            return _context.Set<TEntity>().FirstOrDefault(x => x.ID == id);
        }

        public int Update(TEntity entity)
        {
            _context.Update(entity);
            return _context.SaveChanges();
        }
    }
}
