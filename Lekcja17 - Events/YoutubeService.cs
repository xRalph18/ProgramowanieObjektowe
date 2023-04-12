using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja17___Events
{
    delegate void EventHandler(object sender, EventArgs e);

    class MovieEventArgs : EventArgs
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
    }

    class ShortsEventArgs : EventArgs
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public List<string> ListOfHashTags { get; set; }
    }

    class YoutubeService
    {
        public event EventHandler<MovieEventArgs> OnMoviePublished;
        public event EventHandler<ShortsEventArgs> OnShortsPublished;

        public void OnMovieUpload(string url, string title, string description)
        {
            if (OnMoviePublished != null)
            {
                OnMoviePublished(this, new MovieEventArgs { Url = url, Title = title, Description = description });
            }
        }

        public void OnShortsUpload(string url, string title, List<string> listofhashtags)
        {
            if (OnShortsPublished != null)
            {
                OnShortsPublished(this, new ShortsEventArgs { Url = url, Title = title, ListOfHashTags = listofhashtags });
            }
        }
    }

    class Movie
    {
        public static void Publish(object sender, MovieEventArgs e)
        {
            Console.WriteLine($"Movie {e.Title} was published under {e.Url} and is about {e.Description}");
        }
    }

    class Shorts
    {
        public static void Publish(object sender, ShortsEventArgs e)
        {
            Console.WriteLine($"Movie {e.Title} was published under {e.Url}");

            foreach (var item in e.ListOfHashTags)
            {
                Console.Write($"#{item} ");
            }
        }
    }
}
