namespace cbsStudents.Models.Entities;

public class Task
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
         public int VolunteerId { get; set; }
    }