using HomeTask26102025;
using System;

while (true)
{
    Console.WriteLine("ANA MENYU");
    Console.WriteLine("1. Yeni teatr yarat");
    Console.WriteLine("2. Yeni janr yarat");
    Console.WriteLine("3. Yeni film yarat");
    Console.WriteLine("4. Teatra daxil ol");
    Console.WriteLine("5. Proqramdan çıx");
    Console.Write("Seciminizi daxil edin: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Teatrın adını daxil edin:");
            string tName = Console.ReadLine();
            if (!string.IsNullOrEmpty(tName))
            {
                new Theater(tName);
                Console.WriteLine($"Teatr '{tName}' yaradıldı!");
            }
            break;

        case "2":
            Console.WriteLine("Janrın adını daxil edin:");
            string gName = Console.ReadLine();
            if (!string.IsNullOrEmpty(gName))
            {
                new Genre(gName);
                Console.WriteLine($"Janr '{gName}' yaradıldı!");
            }
            break;

        case "3":
            if (Theater.Theaters.Length == 0)
            {
                Console.WriteLine("Evvelce teatr yaradın!");
                break;
            }
            Console.WriteLine("Filmi hansı teatr ucun yaratmaq isteyirsiniz?");
            for (int i = 0; i < Theater.Theaters.Length; i++)
                Console.WriteLine($"{i + 1}. {Theater.Theaters[i].GetName()}");

            int tIndex;
            while (!int.TryParse(Console.ReadLine(), out tIndex) || tIndex < 1 || tIndex > Theater.Theaters.Length)
            {
                Console.WriteLine("Yanlis secim, yeniden seçin.");
            }

            Theater.Theaters[tIndex - 1].AddMovie();
            break;

        case "4":
            if (Theater.Theaters.Length == 0)
            {
                Console.WriteLine("Evvelce teatr yaradın!");
                break;
            }

            Console.WriteLine("Hansi teatrı secirsiniz?");
            for (int i = 0; i < Theater.Theaters.Length; i++)
                Console.WriteLine($"{i + 1}. {Theater.Theaters[i].GetName()}");

            int thIndex;
            while (!int.TryParse(Console.ReadLine(), out thIndex) || thIndex < 1 || thIndex > Theater.Theaters.Length)
            {
                Console.WriteLine("Yanlış secim, yenidən secin.");
            }

            Theater selectedTheater = Theater.Theaters[thIndex - 1];

            while (true)
            {
                Console.WriteLine($"{selectedTheater.GetName()} MENYU ");
                Console.WriteLine("1. Film elave et");
                Console.WriteLine("2. Filmleri goster");
                Console.WriteLine("3. Film sil");
                Console.WriteLine("4. Teatrdan çıx");

                string subChoice = Console.ReadLine();
                if (subChoice == "1") selectedTheater.AddMovie();
                else if (subChoice == "2") selectedTheater.GetAllMovies();
                else if (subChoice == "3") selectedTheater.RemoveMovie();
                else if (subChoice == "4") break;
                else Console.WriteLine("Yanlıs secim");
            }
            break;

        case "5":
            Console.WriteLine("Proqram dayandırıldı.");
            return;

        default:
            Console.WriteLine("Yanlis seçim, yenidən cehd edin");
            break;
    }
    Console.WriteLine("\nDavam etmek üçün Enter...");
    Console.ReadLine();
    Console.Clear();
}

