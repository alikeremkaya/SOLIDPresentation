using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Yanlıs
{
    public class Dikdortgen
    {
        public virtual int Genislik { get; set; }
        public virtual int Yukseklik { get; set; }

        public int Alan()
        {
            return Genislik * Yukseklik;
        }
    }
}
