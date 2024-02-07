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
    public class KullaniciKisiselRepository : BaseRepository<KullaniciKisisel>, IKullaniciKisiselRepository
    {
        public KullaniciKisiselRepository(DbContext db = null) : base(db ?? new DietAppDBContext())
        {
        }
    }
}
