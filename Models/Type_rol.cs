using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Nightclub.Models
{
    public class Type_rol
    {
        [Key] public required int Id_type_rol { get; set; }
        public required string name_rol {get; set;}
        public List<Event_assistant> event_Assistants{ get; set; }
    }
}