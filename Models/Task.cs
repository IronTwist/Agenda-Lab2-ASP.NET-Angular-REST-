using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaLaborator2.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTimeAdded { get; set; }
        public DateTime DateTimeDeadline { get; set; }
        public string Importance { get; set; }
        public string State { get; set; }
        public DateTime DateTimeClosedAt { get; set; }
    }
}
