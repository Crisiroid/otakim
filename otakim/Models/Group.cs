namespace otakim.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public string ColorHex { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
