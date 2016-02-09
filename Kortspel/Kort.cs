using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Kortspel
{
    enum KortFärg { KLÖVER, RUTER, HJÄRTER, SPADER };
    enum KortValör
    {
        TVÅ = 2, TRE, FYRA, FEM, SEX, SJU, ÅTTA,
        NIO, TIO, KNEKT, DAM, KUNG, ESS
    };


    class Kort : Button
    {
           KortFärg  f;
           KortValör v;
        static string[] färgTab  = {"Kl", "Ru", "Hj", "Sp"};
        static string[] valörTab = {"2", "3", "4", "5", "6", "7", "8",
                               "9", "10", "Kn", "D", "K", "E"};

        bool synligt;
        public static string BildMapp = @"bilder\";
        Image framsida;
        static Image baksida; // Samma bild gäller för alla kort


        // Egenskaper
        public KortFärg Färg
        {
            get { return f; }
        }

        public KortValör Valör
        {
            get { return v; }
        }

        public int Värde
        {
            get { return (int)v; }
        }

        public bool Synligt
        {
            get { return synligt; }
            set { synligt = value; if (!synligt) this.Image = framsida; else this.Image = baksida; }
        }


        // Konstruktorn
        public Kort(KortFärg f, KortValör v, bool synlighet)
        {
            this.f = f;
            this.v = v;
            

            framsida = Image.FromFile(BildMapp + färgTab[(int)f]+ valörTab[Värde -2] + ".gif");
            if (baksida == null)
                baksida = Image.FromFile(BildMapp + "Bak.gif");

            this.Size = framsida.Size;

            Synligt = synlighet; //OBS! Egenskapen Synligt (inte variabeln synligt)
        }

        public Kort(KortFärg f, KortValör v) : this(f, v, false) { }
    }
}
