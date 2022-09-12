using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tårta

{
    public class Tårtan : Choklad
    {
        public string namn;

        // Initialiseringskonstruktör
        public Tårtan(string t)
        {
            namn = t;
        }

        // standardkonstruktör
        public Tårtan()
        {
            namn = "";
        }

    }



}
