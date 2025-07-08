﻿namespace unimarket_backend.Models
{
    public class Message
    {
        public int Id { get; set; }

        public int ConversationId { get; set; }
        public Conversation Conversation { get; set; }

        public int SenderId { get; set; }
        public User Sender { get; set; }

        public string Content { get; set; }
        public DateTime SentAt { get; set; }
        public bool IsRead { get; set; } = false;
    }
}
