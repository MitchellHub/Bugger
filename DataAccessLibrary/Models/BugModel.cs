namespace DataAccessLibrary.Models
{
    public class BugModel
    {
        public int BugId { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public string BugTitle { get; set; }
        public string BugDescription { get; set; }
        public bool BugCompleted { get; set; }
        public bool BugIsArchived { get; set; }
    }
}
