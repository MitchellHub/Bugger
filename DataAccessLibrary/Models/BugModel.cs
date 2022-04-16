namespace DataAccessLibrary.Models
{
    public class BugModel
    {
        public int BugID { get; set; }
        public int UserID { get; set; }
        public int ProjectID { get; set; }
        public string BugTitle { get; set; }
        public string BugDescription { get; set; }
        public bool BugCompleted { get; set; }
        public bool BugIsArchived { get; set; }
    }
}
