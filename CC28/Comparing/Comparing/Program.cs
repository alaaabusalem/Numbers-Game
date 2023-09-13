// See https://aka.ms/new-console-template for more information
using Comparing;

Console.WriteLine("Hello, World!");
Movie[] movies = new Movie[]
		{
			new Movie { Title = "The Matrix", Year = 1999, Genres = new List<string> { "Action", "Sci-Fi" } },
			new Movie { Title = "Inception", Year = 2010, Genres = new List<string> { "Action", "Sci-Fi" } },
			new Movie { Title = "A Beautiful Mind", Year = 2001, Genres = new List<string> { "Drama", "Biography" } },
            // Add more movies here
        };
Comparison compare = new Comparison();
Movie[] orderedByYear = compare.SortByYear(movies);
Console.WriteLine("Ordered by year");

foreach (Movie movie in orderedByYear)
{
	Console.WriteLine($"{movie.Title} year -> {movie.Year}");
}
Movie[] orderedByTitle = compare.SortedAlphabetical(movies);
Console.WriteLine("Sorted Alphabetical");

foreach (Movie movie in orderedByYear)
{
	Console.WriteLine($"{movie.Title}");
}