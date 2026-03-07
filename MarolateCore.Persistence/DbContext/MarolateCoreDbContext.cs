using Microsoft.EntityFrameworkCore;

namespace MarolateCore.Persistence.DbContext
{
    public class MarolateCoreDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public MarolateCoreDbContext(DbContextOptions<MarolateCoreDbContext> options)
            : base(options)
        {
        }

        // فعلاً DbSet نداریم (بعداً در Phase Entity Design اضافه می‌شود)
    }
}
