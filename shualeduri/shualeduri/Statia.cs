using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shualeduri
{
    public class Statia : Gamoqveyneba
    {
        string StatiasSaxeli;
        string StatiaAvtori;
        string GazetisSaxeli;
        string GazetiM;
        int StatiaGamoqveynebisWeli;
        int ArtikleGverdebisRaodenoba;
        public Statia(string StatiasSaxeli, string StatiaAvtori, string GazetisSaxeli, string GazetiM, int StatiaGamoqveynebisWeli, int ArtikleGverdebisRaodenoba)
        {

        }
        public string Statias_Saxeli
        {
            set { this.StatiasSaxeli = value; }
            get { return this.StatiasSaxeli; }
        }
        public string Statia_Avtori
        {
            set { this.StatiaAvtori = value; }
            get { return this.StatiaAvtori; }
        }
        public string Gazetis_Saxeli
        {
            set { this.GazetisSaxeli = value; }
            get { return this.GazetisSaxeli; }
        }
        public string Gazeti_M
        {
            set { this.GazetiM = value; }
            get { return this.GazetiM; }
        }
        public int Statia_GamoqveynebisWeli
        {
            set { this.StatiaGamoqveynebisWeli = value; }
            get { return this.StatiaGamoqveynebisWeli; }
        }
        public int ArtikleGverdebis_Raodenoba
        {
            set { this.ArtikleGverdebisRaodenoba = value; }
            get { return this.ArtikleGverdebisRaodenoba; }
        }
        //
    }
}
