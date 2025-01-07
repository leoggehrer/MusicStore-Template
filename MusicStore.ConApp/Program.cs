using MusicStore.Logic.DataContext;

namespace MusicStore.ConApp
{
    internal class Program
    {
        static void Main(/*string[] args*/)
        {
            int index = 1;
            string input = string.Empty;
            MusicStoreContext context = new();

            while (input.ToLower() != "x")
            {
                Console.Clear();
                Console.WriteLine("MusicStore");
                Console.WriteLine("==========================================");

                Console.WriteLine($"{nameof(Logic.Statistics.MusicStoreStatistics.PrintArtistAndAlbum)}....{index++}");
                Console.WriteLine($"{nameof(Logic.Statistics.MusicStoreStatistics.PrintArtistAndTracks)}...{index++}");
                Console.WriteLine($"{nameof(Logic.Statistics.MusicStoreStatistics.PrintArtistAndTimes)}....{index++}");
                Console.WriteLine($"{nameof(Logic.Statistics.MusicStoreStatistics.PrintAlbumAndTracks)}....{index++}");
                Console.WriteLine($"{nameof(Logic.Statistics.MusicStoreStatistics.PrintAlbumAndTimes)}.....{index++}");
                Console.WriteLine($"{nameof(Logic.Statistics.MusicStoreStatistics.PrintAverageByGenre)}....{index++}");
                Console.WriteLine($"{nameof(Logic.Statistics.MusicStoreStatistics.PrintAverageByAlbum)}....{index++}");
                Console.WriteLine($"{nameof(Logic.Statistics.MusicStoreStatistics.PrintAverageByTrack)}....{index++}");
                Console.WriteLine($"{nameof(Logic.Statistics.MusicStoreStatistics.PrintGenreAndTitles)}....{index++}");

                Console.WriteLine();
                Console.WriteLine($"Exit...............x");
                Console.Write("Your choice:");

                input = Console.ReadLine()!;
                if (Int32.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Logic.Statistics.MusicStoreStatistics.PrintArtistAndAlbum(context);
                            break;
                        case 2:
                            Logic.Statistics.MusicStoreStatistics.PrintArtistAndTracks(context);
                            break;
                        case 3:
                            Logic.Statistics.MusicStoreStatistics.PrintArtistAndTimes(context);
                            break;
                        case 4:
                            Logic.Statistics.MusicStoreStatistics.PrintAlbumAndTracks(context);
                            break;
                        case 5:
                            Logic.Statistics.MusicStoreStatistics.PrintAlbumAndTimes(context);
                            break;
                        case 6:
                            Logic.Statistics.MusicStoreStatistics.PrintAverageByGenre(context);
                            break;
                        case 7:
                            Logic.Statistics.MusicStoreStatistics.PrintAverageByAlbum(context);
                            break;
                        case 8:
                            Logic.Statistics.MusicStoreStatistics.PrintAverageByTrack(context);
                            break;
                        case 9:
                            Logic.Statistics.MusicStoreStatistics.PrintGenreAndTitles(context);
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine();
                    Console.Write("Continue with Enter...");
                    Console.ReadLine();
                }
            }
        }

        private static void PrintGenres(MusicStoreContext context)
        {
            Console.WriteLine();
            Console.WriteLine("Genres:");
            Console.WriteLine("-------");
            foreach (var item in context.GenreSet)
            {
                Console.WriteLine($"{item}");
            }
        }
        private static void PrintArtists(MusicStoreContext context)
        {
            Console.WriteLine();
            Console.WriteLine("Artists:");
            Console.WriteLine("-------");
            foreach (var item in context.ArtistSet)
            {
                Console.WriteLine($"{item}");
            }
        }
        private static void PrintAlbums(MusicStoreContext context)
        {
            Console.WriteLine();
            Console.WriteLine("Albums:");
            Console.WriteLine("-------");
            foreach (var item in context.AlbumSet)
            {
                Console.WriteLine($"{item}");
            }
        }
        private static void PrintTracks(MusicStoreContext context)
        {
            Console.WriteLine();
            Console.WriteLine("Tracks:");
            Console.WriteLine("-------");
            foreach (var item in context.TrackSet)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
