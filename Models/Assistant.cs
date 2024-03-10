using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Nightclub.Models
{
    public class Assistant
    {
        [Key] public required int Id_assistant { get; set; }
        public required string name_assistant { get; set; }
        public required string surname_assistant { get; set; }
        public required string document_number { get; set; }
        public Type_document document_ { get; set; }
        public List<Event_assistant> event_Assistants { get; set; }
    }
}