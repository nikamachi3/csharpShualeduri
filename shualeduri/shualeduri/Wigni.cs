using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shualeduri
{
    public class Wigni : Gamoqveyneba
    {
        string WigniSaxeli;
        string WigniAvtori;
        int GamoqveynebisWeli;
        string Gamomcemelli;
        int GverdebisRaodenoba;

        public Wigni(string WigniSaxeli, string WigniAvtori, int GamoqveynebisWeli, string Gamomcemelli, int GverdebisRaodenoba)
        {

        }
        public string Wigni_Saxeli
        {
            set { this.WigniSaxeli = value; }
            get { return this.WigniSaxeli; }
        }
        public string Wigni_Avtori
        {
            set { this.WigniAvtori = value; }
            get { return this.WigniAvtori; }
        }
        public int Gamoqveynebis_Weli
        {
            set { this.GamoqveynebisWeli = value; }
            get { return this.GamoqveynebisWeli; }
        }
        public string Gamomcemelli_Company
        {
            set { this.Gamomcemelli = value; }
            get { return this.Gamomcemelli; }
        }
        public int Gverdebis_Raodenoba
        {
            set { this.GverdebisRaodenoba = value; }
            get { return this.GverdebisRaodenoba; }
        }
    }
}
