using DietApp.Core;
using DietApp.DAL.IRepositories;
using DietApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.Repositories
{
    public class YemekRepository : BaseRepository<Yemek>, IYemekRepository
    {
        public YemekRepository(DbContext db = null) : base(db ?? new DietAppDBContext())
        {
        }
    }
}
