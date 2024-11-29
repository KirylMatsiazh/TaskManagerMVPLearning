namespace TaskManager.Models
{
    public class UTask : Model
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public UTask(string name, string description, DateTime deadline)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Deadline = deadline;
        }
    }
}
