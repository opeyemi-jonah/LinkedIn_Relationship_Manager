﻿namespace LinkedIn_Relationship_Manager.Models
{
    public class UserMessage
    {
        public int UserId { get; set; }
        public User? User { get; set; }

        public int MessageId { get; set; }
        public Message? Message { get; set; }
    }
}
