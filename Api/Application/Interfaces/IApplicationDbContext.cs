using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Customer> Customers { get; }
        DbSet<Order> Orders { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
