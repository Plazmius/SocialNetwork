using System;
using Njinx.Core.Entities;
using Njinx.DAL.Abstract;

namespace Njinx.DAL.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context = ApplicationDbContext.Create();
        private IRepository<UserProfile> userProfiles;
        private IRepository<Follow> follows;

        public IRepository<UserProfile> UserProfiles => userProfiles ?? (userProfiles = new EfRepository<UserProfile>(_context));
        public IRepository<Follow> Follows => follows ?? (follows = new EfRepository<Follow>(_context));

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
    }
}