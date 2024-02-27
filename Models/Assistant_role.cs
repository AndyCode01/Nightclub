using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Nightclub.Models
{
    public class Assistant_role
    {
        [Key] public required int Id_assistant_role {get; set;}
        public required string name_assistant_role {get; set;}
    }
}