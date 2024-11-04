using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaveldejimoSample.Models
{
    public class Direktorius : Darbuotojas
    {
        public string DarboLaikoPradzia { get; set; }
        public string DarboLaikoPabaiga { get; set; }

        
        public Direktorius(string vardas, string pavarde, long asmensKodas, string darboLaikoPradzia, string darboLaikoPabaiga) 
            : base(vardas, pavarde, asmensKodas)
        {
            DarboLaikoPradzia = darboLaikoPradzia;
            DarboLaikoPabaiga = darboLaikoPabaiga;
        } 
        /*
        public Direktorius(string vardas, string pavarde, long asmensKodas, string darboLaikoPradzia, string darboLaikoPabaiga)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            AsmensKodas = asmensKodas;
            DarboLaikoPradzia = darboLaikoPradzia;
            DarboLaikoPabaiga = darboLaikoPabaiga;
        } */
        public void PakeistiAsmensKoda(long ak)
        {
            AsmensKodas = ak;
        }

        public override string ToString()
        {
            return $"{Vardas} {Pavarde} {AsmensKodas} {DarboLaikoPradzia} - {DarboLaikoPabaiga}";
        }
    }
}
