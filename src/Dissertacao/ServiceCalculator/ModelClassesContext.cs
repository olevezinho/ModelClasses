namespace ServiceCalculator
{
    using Microsoft.EntityFrameworkCore;
    using ModelClasses;

    public class ModelClassesContext : DbContext
    {
        public ModelClassesContext(DbContextOptions<ModelClassesContext> options)
            : base(options)
        {
        }

        public DbSet<Model> Calculators { get; set; }
    }
}
