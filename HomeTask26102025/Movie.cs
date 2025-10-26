using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask26102025
{
    public class Movie:Base
    {
        public string Director;
        public Genre Genre;
        public int AgeLimit;
        public static int IdCounter = 0;

        public Movie(string name,string director ,Genre genre,int agelimit)
        {
            IdCounter++;
            this.Name = name;
            this.Director = director;
            Genre = genre;
            this.AgeLimit = agelimit;
            this.Id = IdCounter;
        }
        public Genre GetGenre()
        {
            return Genre;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Id: {Id} Name: {Name} Director: {Director} Genre: {Genre} Age Limit: {AgeLimit}+");
        }
    }
}
