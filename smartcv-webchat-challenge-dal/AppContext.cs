using smartcv_webchat_challenge_common.Models;
using System.Data.Entity;

namespace smartcv_webchat_challenge_dal
{
    public class AppContext : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'smartcv_webchat_challenge_dal.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public AppContext()
            : base("name=AppContext")
        {
        }


        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
    }
}