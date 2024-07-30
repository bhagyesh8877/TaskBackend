﻿using System;

namespace TaskBackend.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}