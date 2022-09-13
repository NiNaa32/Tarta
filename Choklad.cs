using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tårta
{
    public class Choklad
    {
        public string chokladnamn;
        public double pris;

        public Choklad()
        {
            chokladnamn = "";
            pris = 0.0;
        }

        public Choklad(string n, double pr)
        {
            chokladnamn = n;
            pris = pr;
        }
        public double FörsäljningPris()
        {
            return pris * 1.35;
        }

        public double GenomsnittligtPris(Choklad[] c, int n)
        {
            int i;
            double medelPris = 0.0;
            for (i = 0; i < n; i++)
                medelPris += c[i].FörsäljningPris();
            medelPris /= n;
            return medelPris;
        }

        public double MinPris(Choklad[] c, int n)
        {
            int i;
            double min = c[0].FörsäljningPris();
            for (i = 0; i < n; i++)
                if (min > c[i].FörsäljningPris())
                    min = c[i].FörsäljningPris();
            return min;
        }

    }
}
