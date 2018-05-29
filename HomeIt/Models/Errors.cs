using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Errors
    {
        [Key]
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
    }
}