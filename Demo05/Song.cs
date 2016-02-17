using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Song
    {
        public int Songnum { get; set; }
        public string Songname { get; set; }
        public string Songlength { get; set; }


        public override string ToString()
        {
            return Songnum + " " + Songname + " " + Songlength;
        }

    }
}
