﻿namespace DataAccessLibrary.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserName { get; set; }
        public bool IsArchived { get; set; }
    }
}
