using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaveldejimoSample.Models
{
    public class Darbuotojas
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public long AsmensKodas { get; set; }

        public Darbuotojas(string vardas, string pavarde, long asmensKodas)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            AsmensKodas = asmensKodas;
        }
        public Darbuotojas()
        {

        }
    }
}
