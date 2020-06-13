using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shualeduri
{
    public class Resursebi : Gamoqveyneba
    {
        string ResursisSaxeli;
        string ResursisAvtori;
        string Linki;
        string Anotacia;

        public Resursebi(string ResursisSaxeli, string ResursisAvtori, string Linki, string Anotacia)
        {

        }


        public string Resursis_Saxeli
        {
            set { this.ResursisSaxeli = value; }
            get { return this.ResursisSaxeli; }
        }
        public string Resursis_Avtori
        {
            set { this.ResursisAvtori = value; }
            get { return this.ResursisAvtori; }
        }
        public string Link_i
        {
            set { this.Linki = value; }
            get { return this.Linki; }
        }
        public string Anotacia_A
        {
            set { this.Anotacia = value; }
            get { return this.Anotacia; }
        }

    }
}
