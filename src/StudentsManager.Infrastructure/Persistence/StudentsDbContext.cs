using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StudentsManager.Domain.Entities;

namespace StudentsManager.Infrastructure.Persistence;

public class StudentsDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    private readonly ILogger<StudentsDbContext> _logger;

    public StudentsDbContext(ILogger<StudentsDbContext> logger,
                             DbContextOptions<StudentsDbContext> options) : base(options)
    {
        _logger = logger;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        _logger.LogTrace("Serching for asseblies for configuration.");

        var assembly = Assembly.GetAssembly(typeof(StudentsDbContext)) ?? Assembly.GetCallingAssembly();

        _logger.LogTrace("Serching for asseblies for configuration.");

        _logger.LogTrace("Applying configurations from assembly: {Assembly}", assembly.FullName);

        modelBuilder.ApplyConfigurationsFromAssembly(assembly);

    }
}