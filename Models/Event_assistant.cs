using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Nightclub.Models
{
    public class Event_assistant
    {
        [Key] public int Id_event_assistant { get; set; }
        public Event event_ { get; set; }
        public Assistant assistant_ { get; set; }
        public Type_rol rol_ { get; set; }
    }
}