using System;
using System.ComponentModel.DataAnnotations;
using HomeIt.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HomeIt.Models
{
    public class BaseUtility
    {
        [Key]
        public int Id { get; set; }
        public decimal Used { get; set; }
        public DateTime TimeStamp { get; set; }
        public UtilityTypes UtilityType { get; set; }
        public Guid UserGuid { get; set; }
    }
}