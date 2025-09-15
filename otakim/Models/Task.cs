using System.ComponentModel.DataAnnotations;

namespace otakim.Models
{
    public class Task
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime StartedAt { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime LastUpdatedAt { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime FinishedAt { get; set; }
        public string Status { get; set; }
    }
}
