using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeTask26102025
{
    public class Genre:Base
    {
        private static int IdCounter = 0;
        public static Genre[] AllGenres = new Genre[0];
        public Genre(string name)
        {
            IdCounter++;
            Id = IdCounter;
            Name = name;
        Array.Resize(ref AllGenres, AllGenres.Length + 1);
            AllGenres[AllGenres.Length - 1] = this;
        }
        //public void AddGenre()
        //{
        //    Console.WriteLine("Janrin adini daxil edin");
        //    string name = Console.ReadLine();
        //    if (string.IsNullOrEmpty(name))
        //    {
        //        Console.WriteLine("Ad bos ola bilmez");
        //    }
        //    else
        //    {
        //        Name = name;
        //    Array.Resize(ref AllGenres, AllGenres.Length + 1);
        //    AllGenres[AllGenres.Length - 1] = this;
        //    }
        //}
       
        public override void GetInfo()
        {
            Console.WriteLine($"Id: {Id} Name: {Name}");
        }
    }
}
