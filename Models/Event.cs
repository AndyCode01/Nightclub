using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Nightclub.Models
{
    public class Event
    {
        [Key] public required int Id_event { get; set; }
        public required string title { get; set; }
        public required DateOnly date { get; set; }
        public List<Ticket> ticket{ get; set; }
    }
}