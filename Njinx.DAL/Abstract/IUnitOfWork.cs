using System;
using Njinx.Core.Entities;

namespace Njinx.DAL.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<UserProfile> UserProfiles { get; }
        IRepository<Follow> Follows { get; }
        void SaveChanges();
    }
}