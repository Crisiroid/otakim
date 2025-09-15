namespace otakim.Models
{
    public class Project
    {
        public int Id { get; set; }

        public int CreatorId { get; set; }
        public int AdminId { get; set; }
        public List<User> Users { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Avatar { get; set; }
        public string InviteToken { get; set; }

    }
}
