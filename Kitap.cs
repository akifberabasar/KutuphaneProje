using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProje
{
    internal class Kitap
    {
        //Kitap classı ve propertyleri
        public int ISBN { get; set; }
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public bool Durum { get; set; } = true; // true = zaten var
    }
}