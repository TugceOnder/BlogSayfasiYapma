using Microsoft.EntityFrameworkCore;
using TravelApplication.Models.Siniflar;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;database=TravelDb;trusted_connection=true;");
    }

    public DbSet<Admin> Admins { get; set; }
    public DbSet<AdresBlog> AdresBlogs { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Hakkimizda> Hakkimizdas { get; set; }
    public DbSet<İletisim> Iletisims { get; set; }
    public DbSet<Yorumlar> Yorumlars { get; set; }
     public DbSet<Oteller> Otellers { get; set; }

}
