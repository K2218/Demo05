using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Album
    {
        public string Albumname { get; set;  }
        public string Artist { get; set;  }
        public string Length { get; set; }
        public int Release { get; set; }

        public Album(string albumname, string artist, string lenght, int release)
        {
            Albumname = albumname;
            Artist = artist;
            Length = lenght;
            Release = release;
        }

        public void PrintData()
        {
            Console.WriteLine("Album name: " + Albumname);
            Console.WriteLine("Artst: " + Artist);
            Console.WriteLine("Album length: " + Length);
            Console.WriteLine("Album release: " + Release);
            Console.WriteLine("Songs: ");
        }
      


    }
}
