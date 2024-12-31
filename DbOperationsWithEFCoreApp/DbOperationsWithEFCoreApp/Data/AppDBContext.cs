using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEFCoreApp.Data
{
    public class AppDBContext: DbContext
    {
        // 
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        { 

        }
    }
}
