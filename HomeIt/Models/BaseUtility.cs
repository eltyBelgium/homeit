using System;
using HomeIt.Enums;

namespace HomeIt.Models
{
    public class BaseUtility
    {
        public int Id { get; set; }
        public decimal Used { get; set; }
        public DateTime TimeStamp { get; set; }
        public UtilityTypes UtilityType { get; set; }
        public Guid UserGuid { get; set; }
    }
}