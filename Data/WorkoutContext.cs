using Microsoft.EntityFrameworkCore;
using Workout.Model;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seed data for the user table
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Justin Bartrum", Email = "jbartrum@hotmail.com" },
                new User { Id = 2, Name = "Hank Tank", Email = "htank@hotmail.com" }
                );
            //seed data for exercise
            modelBuilder.Entity<Exercise>().HasData(
                new Exercise { Id = 1, Name = "Chest", Type = Workout.Model.Type.Strength, MuscleGroup = "Pectoralis", Reps = 20, Sets = 4 },
                new Exercise { Id = 2, Name = "Arms", Type = Workout.Model.Type.Strength, MuscleGroup = "Bicep", Reps = 20, Sets = 4 },
                new Exercise { Id = 3, Name = "Yoga", Type = Workout.Model.Type.Flexibility, MuscleGroup = "Core", Reps = 20, Sets = 4 },
                new Exercise { Id = 4, Name = "TreadMill", Type = Workout.Model.Type.Cardio, MuscleGroup = "Core", Duration = 40 });
            //seed data for workoutlog table
            modelBuilder.Entity<WorkoutLog>().HasData(
                new WorkoutLog { Id = 1, Date = DateTime.Today, UserId = 1, ExerciseId = 1 },
                new WorkoutLog { Id = 2, Date = DateTime.Today, UserId = 2, ExerciseId = 4 }
                );
        }

    }

}
