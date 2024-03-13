using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nightclub.Models
{
    public class Client
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)] public required int Id_client { get; set; }
        public required string name_client { get; set; }
        public required string surname_client { get; set; }
        public required string document_number { get; set; }
        public required int type_documentId { get; set; }
        [ForeignKey("type_documentId")] public Type_document type_Document { get; set; }
        public List<Ticket> ticket { get; set; }
    }
}