using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shualeduri
{
    abstract class Gamoqveyneba
    {
        public void printInfo()
        {

        }
        public void searchByDate()
        {
            Console.WriteLine("searching");
        }

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
        public class Artikli : Gamoqveyneba
        {
            string ArtiklisSaxeli;
            string ArtikliAvtori;
            string GazetisSaxeli;
            string GazetiM;
            int ArtikliGamoqveynebisWeli;
            int ArtikleGverdebisRaodenoba;
            public Artikli(string ArtiklisSaxeli, string ArtikliAvtori, string GazetisSaxeli, string GazetiM, int ArtikliGamoqveynebisWeli, int ArtikleGverdebisRaodenoba)
            {

            }
            public string Artiklis_Saxeli
            {
                set { this.ArtiklisSaxeli = value; }
                get { return this.ArtiklisSaxeli; }
            }
            public string Artikli_Avtori
            {
                set { this.ArtikliAvtori = value; }
                get { return this.ArtikliAvtori; }
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
            public int Artikli_GamoqveynebisWeli
            {
                set { this.ArtikliGamoqveynebisWeli = value; }
                get { return this.ArtikliGamoqveynebisWeli; }
            }
            public int ArtikleGverdebis_Raodenoba
            {
                set { this.ArtikleGverdebisRaodenoba = value; }
                get { return this.ArtikleGverdebisRaodenoba; }
            }
            //
        }

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

        static void Main(string[] args)
        {
            //Wigni_#1

            Wigni newWigni = new Wigni("", "", 1945, "", 12);


            newWigni.Wigni_Saxeli = "Graf Monte Kristo";
            newWigni.Wigni_Avtori = "Alexander Duma";
            newWigni.Gamoqveynebis_Weli = 1984;
            newWigni.Gamomcemelli_Company = "Diogene Publishing";
            newWigni.Gverdebis_Raodenoba = 644;
            StringBuilder s = new StringBuilder();
            s.Append("Wigni: ");
            s.Append(newWigni.Wigni_Saxeli);
            s.Append("\nWignis Avtori: ");
            s.Append(newWigni.Wigni_Avtori);
            s.Append("\nGamoqveynebis Weli: ");
            s.Append(newWigni.Gamoqveynebis_Weli);
            s.Append("\nGamomcemeli: ");
            s.Append(newWigni.Gamomcemelli_Company);
            s.Append("\nGverdebis Raodenoba: ");
            s.Append(newWigni.Gverdebis_Raodenoba);
            Console.WriteLine(s.ToString());



            Artikli newArtikli = new Artikli("", "", "", "", 1945, 12);
            newArtikli.Artiklis_Saxeli = "Chokolate Factory In Ohio";
            newArtikli.Artikli_Avtori = "Daily News";
            newArtikli.Gazetis_Saxeli = "Daily News Magazine";
            newArtikli.Gazeti_M = "48";
            newArtikli.Artikli_GamoqveynebisWeli = 2016;
            newArtikli.ArtikleGverdebis_Raodenoba = 13;
            StringBuilder a = new StringBuilder();
            a.Append("\n\nArtiklis Saxeli: ");
            a.Append(newArtikli.Artiklis_Saxeli);
            a.Append("\nArtiklis Avtori: ");
            a.Append(newArtikli.Artikli_Avtori);
            a.Append("\nGazetis Saxeli: ");
            a.Append(newArtikli.Gazetis_Saxeli);
            a.Append("\nGazeti_M: ");
            a.Append(newArtikli.Gazeti_M);
            a.Append("\nArtiklis Gamoqveynebis Weli: ");
            a.Append(newArtikli.Artikli_GamoqveynebisWeli);
            a.Append("\nArtiklis Gverdebis Raodenoba: ");
            a.Append(newArtikli.ArtikleGverdebis_Raodenoba);
            Console.WriteLine(a.ToString());




            Resursebi newResursebi = new Resursebi("", "", "", "");
            newResursebi.Resursis_Saxeli = "C# Book";
            newResursebi.Resursis_Avtori = "Roman Samkharadze";
            newResursebi.Link_i = "https://gtu.ge/book/visual_roman_samxaradze_1.pdf";
            newResursebi.Anotacia_A = "Am Wignshi Sheiswavlit C# detalurad";
            StringBuilder e = new StringBuilder();
            e.Append("\n\nResursis Saxeli: ");
            e.Append(newResursebi.Resursis_Saxeli);
            e.Append("\nResursis Avtori: ");
            e.Append(newResursebi.Resursis_Avtori);
            e.Append("\nLink_i: ");
            e.Append(newResursebi.Link_i);
            e.Append("\nAnotacia A: ");
            e.Append(newResursebi.Anotacia_A);
            Console.WriteLine(e.ToString());






            Console.ReadKey();
        }


    }
}