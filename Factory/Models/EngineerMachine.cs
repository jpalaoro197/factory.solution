namespace UniversityRoster.Models
{
  public class EngineerMachine
    {       
        public int EngineerMachineId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}