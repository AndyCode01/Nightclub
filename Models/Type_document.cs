using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Nightclub.Models
{
    public class Type_document
    {
        [Key] public required int Id_type_document {get; set;}
        public required string name_type_document {get; set;}
        public List<Client> client{ get; set; }
        public List<Assistant> assistant{ get; set; }
        public List<Artist> artist{ get; set; }
    }
}