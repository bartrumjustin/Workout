using Microsoft.EntityFrameworkCore;

namespace Workout.Data
{
    public class WorkoutContext : DbContext
    {
        public WorkoutContext(DbContextOptions<WorkoutContext> options)
            : base(options)
        {
        }

        public DbSet<Workout.Model.User> User { get; set; } = default!;
        public DbSet<Workout.Model.Exercise> Exercise { get; set; } = default!;
        public DbSet<Workout.Model.WorkoutLog> WorkoutLog { get; set; } = default!;
    }
}
