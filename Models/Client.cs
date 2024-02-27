using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Nightclub.Models
{
    public class Client
    {
        [Key] public required int Id_client {get; set;}
        public required string name_client {get; set;}
        public required string surname_client {get; set;}
        public required string document_number {get; set;}
        public Type_document document_ { get; set; }
    }
}