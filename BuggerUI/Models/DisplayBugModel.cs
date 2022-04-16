using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuggerUI.Models
{
    public class DisplayBugModel
    {
        public int BugID { get; set; }

        public int UserID { get; set; }

        public int ProjectID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Bug Subject is too long.")]
        [MinLength(5, ErrorMessage = "Bug Subject is too short.")]
        public string BugTitle { get; set; }

        [MaxLength(3990, ErrorMessage = "Description is too long.")]
        public string BugDescription { get; set; }

        public bool BugCompleted { get; set; }

        public bool BugIsArchived { get; set; }
    }
}