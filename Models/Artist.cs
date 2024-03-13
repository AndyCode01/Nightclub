using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nightclub.Models
{
    public class Artist
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)] public required int Id_artist { get; set; }
        public required string name_artist { get; set; }
        public required string surname_artist { get; set; }
        public required string document_number { get; set; }
        public required int salary_artist { get; set; }
        public required Type_document document_ { get; set; }
        public List<Event_artist> event_Artists { get; set; }
    }
}