using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakultetDataLayer.Models
{
    public class Termin
    {
        public int Id { get; set; }
        public  DateTime VremePocetka { get; set; }
        public DateTime VremeZavrsetka { get; set; }
    }
}
