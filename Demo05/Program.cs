using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();

            Album album = new Album("My Beautiful Dark Twisted Fantasy", "Kanye West", "60:08", 2010);

            album.PrintData();

            songs.Add(new Song { Songnum = 1, Songname = "Dark Fantasy", Songlength = "4:41" });
            songs.Add(new Song { Songnum = 2, Songname = "Gorgeous", Songlength = "5:58" });
            songs.Add(new Song { Songnum = 3, Songname = "Power", Songlength = "4:52" });
            songs.Add(new Song { Songnum = 4, Songname = "All Of The Lights(Interlude)", Songlength = "1:02" });
            songs.Add(new Song { Songnum = 5, Songname = "All Of The Lights", Songlength = "5:00" });
            songs.Add(new Song { Songnum = 6, Songname = "Monster", Songlength = "6:19" });
            songs.Add(new Song { Songnum = 7, Songname = "So Appalled", Songlength = "6:38" });
            songs.Add(new Song { Songnum = 8, Songname = "Devil In A New Dress", Songlength = "5:52" });
            songs.Add(new Song { Songnum = 9, Songname = "Runaway", Songlength = "9:08" });
            songs.Add(new Song { Songnum = 10, Songname = "Hell Of A Life", Songlength = "5:28" });
            songs.Add(new Song { Songnum = 11, Songname = "Blame Game", Songlength = "7:50" });
            songs.Add(new Song { Songnum = 12, Songname = "Lost In The World", Songlength = "4:17" });
            songs.Add(new Song { Songnum = 13, Songname = "Who Will Survive In America", Songlength = "1:38" });

            foreach (Song song in songs)
            {
                Console.WriteLine(song.ToString());
            }

            Console.ReadLine();
        }
    }
}
