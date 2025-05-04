using Microsoft.EntityFrameworkCore;

namespace Orocto.ExpenseMate.Translation.ApplicationDbContext;

/// <summary>
/// 
/// </summary>
public class ExpenseMateDbContext : DbContext
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="options"></param>
    public ExpenseMateDbContext(DbContextOptions<ExpenseMateDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<>().HasNoKey();
    }
}