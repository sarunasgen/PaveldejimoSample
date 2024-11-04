using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaveldejimoSample.Models
{
    public class Vadybininkas : Darbuotojas
    {
        public List<string> AtliktiProjektai { get; set; }

        public Vadybininkas(string vardas, string pavarde, long asmensKodas, List<string> atliktiProjektai) : base(vardas, pavarde, asmensKodas)
        {
            AtliktiProjektai = atliktiProjektai;
        }

        public override string ToString()
        {
            string result = $"{Vardas} {Pavarde} {AsmensKodas} Atlikti Projektai: ";

            foreach (string s in AtliktiProjektai)
            {
                result += s + " ";
            }

            return result;
        }
    }
}
