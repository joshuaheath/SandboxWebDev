using Microsoft.EntityFrameworkCore;

public class SandboxWebDevContext(DbContextOptions<SandboxWebDevContext> options) : DbContext(options)
{
    public DbSet<SandboxWebDev.Models.Trail> Trail { get; set; } = default!;
}
