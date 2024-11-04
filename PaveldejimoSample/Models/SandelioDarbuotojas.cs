using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaveldejimoSample.Models
{
    public class SandelioDarbuotojas : Darbuotojas 
    {
        public int IsdirbtosValandos { get; set; }
        public SandelioDarbuotojas(string vardas, string pavarde, long asmensKodas, int isdirbtosValandos) : base(vardas, pavarde, asmensKodas)
        {
            IsdirbtosValandos = isdirbtosValandos;
        }
        public override string ToString()
        {
            return $"{Vardas} {Pavarde} {AsmensKodas} Isdirbtos valandos: {IsdirbtosValandos}";
        }
    }
}
