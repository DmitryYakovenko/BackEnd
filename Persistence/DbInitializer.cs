using Persistence;

namespace Persistence
{
    public class DbInitializer
    {
        public static void Initialize(BaseDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
