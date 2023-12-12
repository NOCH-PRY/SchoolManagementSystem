using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem_API.Data;

namespace SchoolManagementSystem_API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services, WebApplicationBuilder builder)
        {
            // Add DbContext
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolManagementDB")));

            // Add controllers
            services.AddControllers();
        }
    }
}
