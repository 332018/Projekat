using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakultetDataLayer.Models
{
    public class Rezervacija
    {
        public int Termini_Id { get; set; }
        public int Broj_Ucionice { get; set; }
        public int Dan { get; set; }
        public int Sifra_Predmeta { get; set; }
        public int Id_Profesora { get; set; }
    }
}
