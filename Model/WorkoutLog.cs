using System.ComponentModel.DataAnnotations;

namespace Workout.Model
{
    public class WorkoutLog
    {
        //Primary Key
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        //foreign key
        [Display(Name = "User")]
        public int UserId { get; set; }
        public User? User { get; set; }

        //foreign key
        [Display(Name = "Exercise")]
        public int ExerciseId { get; set; }
        public Exercise? Exercise { get; set; }
    }
}
