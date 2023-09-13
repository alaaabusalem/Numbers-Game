using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing
{
	public class Comparison
	{

		public Movie[] SortByYear(Movie[] movies)
		{
			int size = movies.Length;
			Movie[] result = movies;
			for (int i = 0; i < result.Length - 1; i++)
			{
				for (int j = i + 1; j < result.Length - 1; j++)
				{
					if (result[i].Year < result[j].Year)
					{
						var moviei = result[i];
						result[i] = result[j];
						result[j] = moviei;
					}
				}

			}
			return result;

		}

		public Movie[] SortedAlphabetical(Movie[] movies)
		{
			int size = movies.Length;


			Movie[] result = RemoveLeadingArticles(movies);
			for (int i = 0; i < result.Length - 1; i++)
			{
				for (int j = i + 1; j < result.Length - 1; j++)
				{
					int value = result[i].Title.CompareTo(result[j].Title);
					if (value < 0)
					{
						var moviei = result[i];
						result[i] = result[j];
						result[j] = moviei;

					}
				}

			}
			return result;
		}

		private Movie[] RemoveLeadingArticles(Movie[] movies)
		{
			string[] articles = { "A ", "An ", "The " };
			for (int i = 0; i < movies.Length; i++)
			{
				foreach (string article in articles)
				{
					if (movies[i].Title.StartsWith(article))
					{
						movies[i].Title = movies[i].Title.Substring(article.Length);

					}
				}

			}
			return movies;
		}
	}
}
