using System;
using System.Linq;

namespace HomeTask26102025
{
    public class Theater : Base
    {
        public static Movie[] Movies = new Movie[0];
        public static int idCounter = 0;
        public static Theater[] Theaters = new Theater[0];

        public Theater(string name)
        {
            idCounter++;
            Id = idCounter;
            this.Name = name;
            Array.Resize(ref Theaters, Theaters.Length + 1);
            Theaters[Theaters.Length - 1] = this;
            Console.WriteLine("Teatr yaradildi");
        }
        //public void AddTheater()
        //{
        //    Console.WriteLine("Teatrin adini daxil edin");
        //    string name = Console.ReadLine();
        //    if (string.IsNullOrEmpty(name))
        //    {
        //        Console.WriteLine("Ad bos ola bilmez");
        //    }
        //    else
        //    {
        //        Name = name;
        //        Array.Resize(ref Theaters, Theaters.Length + 1);
        //        Theaters[Theaters.Length - 1] = this;
        //    }
        //}



        public override void GetInfo()
        {
            Console.WriteLine($"Id: {Id} Name: {Name}");
        }

        public  void AddMovie()
        {
            if (Genre.AllGenres.Length==0)
            {
                Console.WriteLine("Evvelce Janr elave edin");
                return;
            }

        restartname:
            Console.WriteLine("Filmin adini daxil edin");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Filmin adi bos ola bilmez");
            goto restartname;
            }
            restartdirector:
            Console.WriteLine("Filmin rejissorunu daxil edin");
            string director = Console.ReadLine();
            if (string.IsNullOrEmpty(director))
            {
                Console.WriteLine("Filmin rejissoru bos ola bilmez");
                goto restartdirector;
            }
            restartgenre:
            Console.WriteLine("Filmin janrini secin ");
            int genreIndex;
            for (int i = 0; i < Genre.AllGenres.Length; i++)
            {
                Console.WriteLine($"{i+1}. {Genre.AllGenres[i].GetName()}");
            }
                string input=Console.ReadLine();
            while (!int.TryParse(input, out genreIndex) || genreIndex < 1 || genreIndex > Genre.AllGenres.Length) {
                Console.WriteLine("Yanlış seçim, yeniden seçin.");
                    goto restartgenre;
            }
            restartagelimit:
            Console.WriteLine("Filmin yas limitini daxil edin (13,16,18)");
            int ageLimit;
            while (!int.TryParse(Console.ReadLine(), out ageLimit) || (ageLimit != 13 && ageLimit != 16 && ageLimit != 18))
            {
                Console.WriteLine("Yanlış deyer, 13,16 və ya 18 daxil edin.");
                goto restartagelimit;
            }
            Movie movie=  new Movie(name, director, Genre.AllGenres[genreIndex-1], ageLimit);
            Array.Resize(ref Movies, Movies.Length + 1);
            Movies[Movies.Length - 1] = movie;
            Console.WriteLine("Film Elave olundu");
        }
        public void GetAllMovies()
        {
            Console.WriteLine("Butun Filmler");
            foreach (var movie in Movies)
            {
                movie.GetInfo();
            }
        }
        public void RemoveMovie()
        {
            if (Movies.Length==0)
            {
                Console.WriteLine("Hecbir film yoxdur");
                return;
            }
            GetAllMovies();
            Console.WriteLine("Filmin id sini daxil edin");
            int id = Convert.ToInt32(Console.ReadLine());

            int index = Array.FindIndex(Movies, m => m.GetId() == id);
            if (index == -1)
            {
                Console.WriteLine("Bele film tapilmadi");
                return;
            }
            for (int i = index; i < Movies.Length - 1; i++)
            {
                Movies[i] = Movies[i + 1];
            }
            Array.Resize(ref Movies, Movies.Length - 1);
        }
    }
}
