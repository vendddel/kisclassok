using kisclassok;
using System.Security.Cryptography;

Book hobbit = new Book("Hobbit", "Gulyas Gergely", 3213)
{
    Price = 6500
};
hobbit.UpdatePrice(20);
Console.WriteLine(hobbit);

Book Dune = hobbit with { Author = "Frank Herbert", Title = "Dune", Pages = 688 };
Console.WriteLine(Dune);


Student anna = new Student("Anna", "10.S", 2010) { };

anna.UpdateAverage(4.7);
Console.WriteLine(anna);
Console.WriteLine(anna.Grading());

Student Bence = new Student("Bence", "12.K", 2007) { };
Bence.UpdateAverage(3.5);
Console.WriteLine(Bence);
Console.WriteLine(Bence.Grading());

VideoGames cyberpunk = new VideoGames("cp2077", "CD ize", 2020) { _rating = 8.6 };
cyberpunk.UpdatePrice(19990);
Console.WriteLine(cyberpunk);
Console.WriteLine(cyberpunk.CanIBuy(140000));
Console.WriteLine(cyberpunk.HowOld(DateTime.Now.Year));

VideoGames redead = new VideoGames("rdr2", "Roksztar", 2018) { _rating = 9.6 };
redead.UpdatePrice(18990);
Console.WriteLine(redead);
Console.WriteLine(redead.CanIBuy(140000));
Console.WriteLine(redead.HowOld(DateTime.Now.Year));

Employee peter = new Employee("peter", "developer");
peter.UpdateWage(6500000);
Console.WriteLine(peter.OverTimeWage());
peter.UpdateWage(15);
Console.WriteLine(peter);

Employee eva = new Employee("Szabo Eva", "Designer");
eva.UpdateWage(580000);
Console.WriteLine(eva.OverTimeWage());
Console.WriteLine(eva);


FootballPlayer daniel = new FootballPlayer("Daniel Kovacs", "Hungarian", 2001) {};
daniel.UpdateStats(2);
daniel.TransferTo("Budapest FC");
FootballPlayer adam = new FootballPlayer("Adam Nagy", "Hungarian", 2005) { };
adam.UpdateStats(1);
adam.TransferTo("Lake United");
daniel.GoalAverage();
adam.GoalAverage();
Console.WriteLine(daniel);
Console.WriteLine(adam);

// Példányosíts egy Movie objektumot:
// "Interstellar", "Christopher Nolan", "SciFi", 2014, 8.7, 2500000

Movie film = new Movie("Interstellar", "Christopher Nolan", "SciFi", 2014);
film.UpdateRating(9.0);
Console.WriteLine(film);


Movie film2 = film with { Title = "Interstellar Extended"};
Console.WriteLine(film2);

Movie film3 = film with { Director = "John Smith" };
Console.WriteLine(film3);
