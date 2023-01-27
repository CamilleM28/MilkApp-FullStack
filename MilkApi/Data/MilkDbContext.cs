using Microsoft.EntityFrameworkCore;
using MilkApi.Models;

namespace MilkApi.Data;

public class MilkDbContext : DbContext
{
    public MilkDbContext(DbContextOptions<MilkDbContext> options) : base(options)
    {

    }

    public DbSet<Milk> Milk { get; set; } = null!;
}