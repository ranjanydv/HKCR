using HKCR.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKCR.Domain.Entities
{
    public class Document
    {

        public Guid DocId { get; set; } = new Guid();
        public string Type { get; set; }
        public string DocPath { get; set; }

        // [ForeignKey("Department")]
        // public int DepartmentId { get; set; }
        // public virtual Department Department { get; set; }
    }
}
