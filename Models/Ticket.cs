using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Nightclub.Models
{
    public class Ticket
    {
        [Key] public required int Id_ticket { get; set; }
        public required string qr {get; set;}
        public required DateOnly date_join {get; set;}
        public Event event_ { get; set; }
        public Client client_ { get; set; }
    }
}