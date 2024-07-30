namespace TaskBackend.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int TaskId { get; set; }
        public TaskItem Task { get; set; }
    }
}
