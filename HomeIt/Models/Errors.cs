using System;
using System.Diagnostics;

namespace HomeIt.Models
{
    public class Errors
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
    }
}