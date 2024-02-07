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
    public class VucutIndeksiRepository : BaseRepository<KullaniciKisisel>, IVucutIndeksiRepository
    {
        public VucutIndeksiRepository(DbContext context = null) : base(context ?? new DietAppDBContext())
        {
        }
    }
}
