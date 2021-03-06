using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CamKyscn.Entities
{
    public class Banda
    {
        public long Id { get; set; }
        public string Codigo { get; set; }
        public long? PaqueteId { get; set; }

    }
}
