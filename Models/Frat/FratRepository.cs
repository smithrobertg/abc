using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Airborne.Commander.AspNetCore.Models
{
    public class FratRepository : IFratRepository
    {
        private AppDbContext _appDbContext;

        public FratRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Frat> Frats
        {
            get => _appDbContext.Frats
               .Include(f => f.Aircraft)
               .Include(f => f.StaticFrat);
        }

        public IEnumerable<StaticFrat> StaticFrats { get => _appDbContext.StaticFrats; }

        public Frat GetFratById(int id) => _appDbContext.Frats
                                                .Include(f => f.Aircraft)
                                                .Include(f => f.StaticFrat)
                                                .FirstOrDefault(f => f.Id == id);

        public StaticFrat GetStaticFratById(int id) => _appDbContext.StaticFrats.FirstOrDefault(s => s.Id == id);

        public void Add(Frat frat)
        {
            if (frat != null)
            {
                _appDbContext.Frats.Add(frat);
                _appDbContext.SaveChanges();
            }
        }
        public void Update(Frat frat)
        {
            if (frat != null)
            {
                _appDbContext.Frats.Update(frat);
                _appDbContext.SaveChanges();
            }
        }
        public void Delete(Frat frat)
        {
            if (frat != null)
            {
                _appDbContext.Frats.Remove(frat);
                _appDbContext.SaveChanges();
            }
        }

        public void Add(StaticFrat staticFrat)
        {
            if (staticFrat != null)
            {
                _appDbContext.StaticFrats.Add(staticFrat);
                _appDbContext.SaveChanges();
            }
        }
        public void Update(StaticFrat staticFrat)
        {
            if (staticFrat != null)
            {
                _appDbContext.StaticFrats.Update(staticFrat);
                _appDbContext.SaveChanges();
            }
        }
        public void Delete(StaticFrat staticFrat)
        {
            if (staticFrat != null)
            {
                _appDbContext.StaticFrats.Remove(staticFrat);
                _appDbContext.SaveChanges();
            }
        }
    }
}
