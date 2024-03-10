using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Nightclub.Models
{
    public class Event_artist
    {
      [Key] public required int Id_event_artist { get; set; }
      public Event event_ { get; set; }
      public Artist artist_ { get; set; }
      
    }
}